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
        public PagoForm(Usuario usuario, decimal monto)
        {
            this.usuario = usuario;
            this.monto = monto;
            //this.turno = turno;
            //this.servicio = servicio;
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
                    string imagePath = "SentirseBien.Resources.logo.jpg"; // Cambia 'TuNamespace' por el namespace real de tu proyecto
                    using (var stream = typeof(PagoForm).Assembly.GetManifestResourceStream(imagePath))
                    {
                        if (stream != null)
                        {
                            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(stream);
                            image.ScaleToFit(doc.PageSize.Width - doc.LeftMargin - doc.RightMargin, 100); // Escalar la imagen
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
                    doc.Add(new Paragraph("COMPROBANTE DE TURNO"));
                    doc.Add(Chunk.NEWLINE);

                    PdfPTable pdfptable = new PdfPTable(3) { WidthPercentage = 100 };

                    // Encabezados de la tabla
                    pdfptable.AddCell(new PdfPCell(new Phrase("Nombre", standarFont)) { BorderWidth = 0, BorderWidthBottom = 0.75f });
                    pdfptable.AddCell(new PdfPCell(new Phrase("Servicio", standarFont)) { BorderWidth = 0, BorderWidthBottom = 0.75f });
                    pdfptable.AddCell(new PdfPCell(new Phrase("Monto", standarFont)) { BorderWidth = 0, BorderWidthBottom = 0.75f });

                    // Agregar datos
                    pdfptable.AddCell(new PdfPCell(new Phrase(usuario.nombre ?? "N/A", standarFont))); // Manejar valores nulos
                    pdfptable.AddCell(new PdfPCell(new Phrase(turno.servicio ?? "N/A", standarFont))); // Manejar valores nulos
                    pdfptable.AddCell(new PdfPCell(new Phrase(monto.ToString(), standarFont)));

                    doc.Add(pdfptable);
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
            this.Close();
        }




        /* private void aceptar_button_Click(object sender, EventArgs e)
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
                 try
                 {
                     using (FileStream file = new FileStream(saveFileDialog.FileName, FileMode.Create))
                     using (PdfWriter pw = PdfWriter.GetInstance(doc, file))
                     {
                         doc.Open();
                         doc.AddAuthor("Dra Ana Felicidad");
                         doc.AddTitle("Comprobante de Turno");

                         // Fuente
                         iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                         // Encabezado
                         doc.Add(new Paragraph("COMPROBANTE DE TURNO"));
                         doc.Add(Chunk.NEWLINE);

                         PdfPTable pdfptable = new PdfPTable(3) { WidthPercentage = 100 };

                         // Encabezados de la tabla
                         pdfptable.AddCell(new PdfPCell(new Phrase("Nombre", standarFont)) { BorderWidth = 0, BorderWidthBottom = 0.75f });
                         pdfptable.AddCell(new PdfPCell(new Phrase("Servicio", standarFont)) { BorderWidth = 0, BorderWidthBottom = 0.75f });
                         pdfptable.AddCell(new PdfPCell(new Phrase("Monto", standarFont)) { BorderWidth = 0, BorderWidthBottom = 0.75f });

                         // Agregar datos
                         pdfptable.AddCell(new PdfPCell(new Phrase(usuario.nombre ?? "N/A", standarFont))); // Manejar valores nulos
                         pdfptable.AddCell(new PdfPCell(new Phrase(turno.servicio ?? "N/A", standarFont))); // Manejar valores nulos
                         pdfptable.AddCell(new PdfPCell(new Phrase("$1000", standarFont)));

                         doc.Add(pdfptable);
                         MessageBox.Show("Archivo guardado en: " + saveFileDialog.FileName);
                     }
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
             /*
             FileStream file = null;
             Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
             SaveFileDialog saveFileDialog = new SaveFileDialog();
             saveFileDialog.Title = "Guardar Archivo";
             saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
             saveFileDialog.DefaultExt = "pdf";
             saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
             if (saveFileDialog.ShowDialog() == DialogResult.OK)
             {
                 // Obtener la ruta seleccionada por el usuario
                 file = new FileStream(saveFileDialog.FileName, FileMode.Create);
                 PdfWriter pw = PdfWriter.GetInstance(doc, file);
                 //PDF
                 doc.Open();
                 doc.AddAuthor("Dra Ana Felicidad");
                 doc.AddTitle("Comprobante de Turno");
                 //fuente
                 iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                 //encabezado
                 doc.Add(new Paragraph("COMPROBANTE DE TURNO"));
                 doc.Add(Chunk.NEWLINE);
                 PdfPTable pdfptable = new PdfPTable(3);
                 pdfptable.WidthPercentage = 100;

                 PdfPCell pdfPCellNombre = new PdfPCell(new Phrase("Nombre", standarFont));
                 pdfPCellNombre.BorderWidth = 0;
                 pdfPCellNombre.BorderWidthBottom = 0.75f;
                 PdfPCell pdfPCellServicio = new PdfPCell(new Phrase("Servicio", standarFont));
                 pdfPCellServicio.BorderWidth = 0;
                 pdfPCellServicio.BorderWidthBottom = 0.75f;
                 PdfPCell pdfPCellMonto = new PdfPCell(new Phrase("Monto", standarFont));
                 pdfPCellMonto.BorderWidth = 0;
                 pdfPCellMonto.BorderWidthBottom = 0.75f;

                 //agregar datos
                 pdfPCellNombre = new PdfPCell(new Phrase(usuario.nombre, standarFont));
                 pdfPCellServicio = new PdfPCell(new Phrase(turno.servicio));
                 pdfPCellMonto = new PdfPCell(new Phrase("$1000", standarFont));

                 pdfptable.AddCell(pdfPCellNombre);
                 pdfptable.AddCell(pdfPCellServicio);
                 pdfptable.AddCell(pdfPCellMonto);

                 doc.Add(pdfptable);
                 doc.Close();
                 pw.Close();
                 MessageBox.Show("Archivo guardado en: " + saveFileDialog.FileName);
             }

             DialogResult = DialogResult.OK;
             this.Close();
         }*/

        private void Crearpago() 
        {
            
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
