using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SentirseBien
{
    public partial class PagoForm : Form
    {
        private Usuario usuario = new Usuario();
        private Turno turno = new Turno();
        Pago pago = new Pago();
        private ConexionMysql conexionMysql;
        Servicio servicio;
        decimal monto;
        List<Pago> pagos;
        public PagoForm(Usuario usuario, decimal monto, List<Pago> pagos)
        {
            this.usuario = usuario;
            this.monto = monto;
            this.pagos = pagos;
            conexionMysql = new ConexionMysql();
            InitializeComponent();
        }

        private void aceptar_button_Click(object sender, EventArgs e)
        {
                Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = "Guardar Archivo",
                    Filter = "Archivo PDF (*.pdf)|*.pdf",
                    DefaultExt = "pdf",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = null;
                    try
                    {
                        file = new FileStream(saveFileDialog.FileName, FileMode.Create);
                        PdfWriter pw = PdfWriter.GetInstance(doc, file);
                        doc.Open();
                        doc.AddAuthor("Dra Ana Felicidad");
                        doc.AddTitle("Comprobante de Turno");

                        // Agregar imagen embebida
                        string imagePath = "SentirseBien.Resources.logo.jpg";
                        using (var stream = typeof(PagoForm).Assembly.GetManifestResourceStream(imagePath))
                        {
                            if (stream != null)
                            {
                                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(stream);
                                image.ScaleToFit(doc.PageSize.Width - doc.LeftMargin - doc.RightMargin, 100); // Escalar la imagen
                                image.Alignment = Element.ALIGN_CENTER; // Centrar la imagen
                                doc.Add(image); // Agregar la imagen al documento
                            }
                            else
                            {
                                MessageBox.Show("No se encontró la imagen embebida.");
                                return; // Salir si no se encuentra la imagen
                            }
                        }

                        // Fuente
                        iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                        // Encabezado
                        doc.Add(new Paragraph("COMPROBANTE DE TURNO", standarFont) { Alignment = Element.ALIGN_CENTER });
                        doc.Add(Chunk.NEWLINE);

                        // Crear una tabla con 2 columnas
                        PdfPTable pdfptable = new PdfPTable(3) { WidthPercentage = 100 };
                        float[] columnWidths = { 0.4f, 0.4f, 0.2f }; // Ajusta el ancho de las columnas
                        pdfptable.SetWidths(columnWidths);

                        // Agregar espaciado entre celdas
                        pdfptable.SpacingBefore = 10f; // Espacio antes de la tabla
                        pdfptable.SpacingAfter = 10f;  // Espacio después de la tabla

                        // Encabezados de la tabla
                        pdfptable.AddCell(new PdfPCell(new Phrase("Nombre", standarFont)) { BorderWidth = 0, BorderWidthBottom = 0.75f });
                        pdfptable.AddCell(new PdfPCell(new Phrase("Servicio", standarFont)) { BorderWidth = 0, BorderWidthBottom = 0.75f });
                        pdfptable.AddCell(new PdfPCell(new Phrase($"$Precio", standarFont)) { BorderWidth = 0, BorderWidthBottom = 0.75f });

                        // Agregar datos a la tabla
                        int i = 0;
                        while (i < pagos.Count)
                        {
                            pdfptable.AddCell(new PdfPCell(new Phrase(usuario.nombre ?? "N/A", standarFont)) { BorderWidth = 0 });
                            pdfptable.AddCell(new PdfPCell(new Phrase(pagos[i].servicio ?? "N/A", standarFont)) { BorderWidth = 0 });
                            pdfptable.AddCell(new PdfPCell(new Phrase($"${pagos[i].monto.ToString("N2")}", standarFont)) { BorderWidth = 0 }); // Agregar el precio con el símbolo de pesos
                            i++;
                        }

                        doc.Add(pdfptable);
                        doc.Add(Chunk.NEWLINE); // Dejar espacio antes del monto

                        // Posicionar el monto total en la parte inferior derecha
                        PdfContentByte cb = pw.DirectContent;
                        cb.BeginText();

                        // Configuración de la fuente para el monto
                        BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                        cb.SetFontAndSize(bf, 12); // Tamaño de la fuente

                        // Alinear y mostrar el texto en la parte inferior derecha
                        cb.ShowTextAligned(Element.ALIGN_RIGHT, $"Monto total: ${monto.ToString("N2")}", doc.PageSize.Width - doc.RightMargin, doc.BottomMargin + 20, 0);

                        cb.EndText();

                        MessageBox.Show("Archivo guardado en: " + saveFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el PDF: " + ex.Message);
                    }
                    finally
                    {
                        doc.Close(); // Asegúrate de cerrar el documento
                    }
                }

                DialogResult = DialogResult.OK;
                ReflejarPago();
                this.Close();
            
        }

        private void ReflejarPago()
        {

            using (MySqlConnection connection = conexionMysql.GetConnection())
            {


                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string QUERY = "UPDATE pagos SET estado = @nuevoEstado, mediodepago = @nuevoMediodepago WHERE estado = 'pendiente' AND numeropago = @numeropago";
                        foreach (var pago in pagos)
                        {
                           
                            using (MySqlCommand command = new MySqlCommand(QUERY, connection, transaction))
                            {
                                // Parámetros para la consulta SQL
                                command.Parameters.AddWithValue("@nuevoEstado", "pagado");
                                command.Parameters.AddWithValue("@numeropago", pago.nropago);
                                command.Parameters.AddWithValue("@nuevoMediodepago", tarjeta_combox.Text); // Actualizar mediodepago
                                MessageBox.Show("el numero del pago que queres actualizar es: "+ pago.nropago);

                                int filasAfectadas = command.ExecuteNonQuery();  // Ejecuta la consulta de actualización

                                if (filasAfectadas > 0)
                                {
                                    MessageBox.Show("El estado del pago '" + pago.nropago + "' ha sido actualizado a 'pagado'.");
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró el pago especificado: " + pago.nropago);
                                }
                            }
                        }

                        transaction.Commit();  // Confirma la transacción
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();  // Revierte la transacción en caso de error
                        MessageBox.Show("Error al actualizar el estado del pago: " + ex.Message);
                    }
                }


            }
            
        }


        private void cancelarBoton_click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelAceptarPago_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tarjeta_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tarjeta_combox.SelectedItem.ToString() == "Crédito")
            {
                cuotas_combobox.Visible = true; // Mostramos el segundo ComboBox
            }
            else
            {
                cuotas_combobox.Visible = false; // Ocultamos el segundo ComboBox
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
