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
using iTextSharp.text.pdf.draw;
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

                    // Línea separadora como un Chunk en lugar de una celda de tabla
                    Paragraph separatorLine = new Paragraph(new Chunk(new LineSeparator(1f, 100f, BaseColor.LIGHT_GRAY, Element.ALIGN_CENTER, -2)));
                    doc.Add(separatorLine);


                    // Encabezado
                    iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    Paragraph header = new Paragraph("COMPROBANTE DE TURNO", headerFont) { Alignment = Element.ALIGN_CENTER };
                    doc.Add(header);
                    doc.Add(Chunk.NEWLINE);

                    // Crear la tabla con estilos en los encabezados
                    PdfPTable pdfptable = new PdfPTable(3) { WidthPercentage = 100 };
                    float[] columnWidths = { 0.4f, 0.4f, 0.2f };
                    pdfptable.SetWidths(columnWidths);
                    pdfptable.SpacingBefore = 10f;
                    pdfptable.SpacingAfter = 10f;

                    // Encabezados de la tabla con estilo
                    iTextSharp.text.Font tableHeaderFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY);
                    pdfptable.AddCell(new PdfPCell(new Phrase("Nombre", tableHeaderFont)) { BorderWidthBottom = 0.75f });
                    pdfptable.AddCell(new PdfPCell(new Phrase("Servicio", tableHeaderFont)) { BorderWidthBottom = 0.75f });
                    pdfptable.AddCell(new PdfPCell(new Phrase("$Precio", tableHeaderFont)) { BorderWidthBottom = 0.75f });

                    // Datos de la tabla
                    iTextSharp.text.Font dataFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    int i = 0;
                    while (i < pagos.Count)
                    {
                        pdfptable.AddCell(new PdfPCell(new Phrase(usuario.nombre ?? "N/A", dataFont)) { BorderWidth = 0 });
                        pdfptable.AddCell(new PdfPCell(new Phrase(pagos[i].servicio ?? "N/A", dataFont)) { BorderWidth = 0 });
                        pdfptable.AddCell(new PdfPCell(new Phrase($"${pagos[i].monto.ToString("N2")}", dataFont)) { BorderWidth = 0 });
                        i++;
                    }

                    doc.Add(pdfptable);
                    doc.Add(Chunk.NEWLINE);

                    // Monto total en negrita y tamaño más grande
                    PdfContentByte cb = pw.DirectContent;
                    cb.BeginText();
                    BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    cb.SetFontAndSize(bf, 12);
                    cb.SetColorFill(BaseColor.BLACK);
                    cb.ShowTextAligned(Element.ALIGN_RIGHT, $"Monto total: ${monto.ToString("N2")}", doc.PageSize.Width - doc.RightMargin, doc.BottomMargin + 20, 0);
                    cb.EndText();

                    // Agregar fecha y hora en la parte inferior izquierda
                    cb.BeginText();
                    cb.SetFontAndSize(bf, 8);
                    cb.ShowTextAligned(Element.ALIGN_LEFT, "Fecha de emisión: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), doc.LeftMargin, doc.BottomMargin + 20, 0);
                    cb.EndText();

                    // Información de contacto en la parte inferior central
                    cb.BeginText();
                    cb.SetFontAndSize(bf, 8);
                    cb.ShowTextAligned(Element.ALIGN_CENTER, "Contacto: (123) 456-7890 | email@empresa.com", doc.PageSize.Width / 2, doc.BottomMargin, 0);
                    cb.EndText();

                    MessageBox.Show("Archivo guardado en: " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message);
                }
                finally
                {
                    doc.Close();
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
                                //MessageBox.Show("el numero del pago que queres actualizar es: " + pago.nropago);

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

        private void NumeroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o una tecla de control (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancela el evento
                e.Handled = true;
            }
        }

        private void CodSegKeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o una tecla de control (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancela el evento
                e.Handled = true;
            }
        }
    }
}
