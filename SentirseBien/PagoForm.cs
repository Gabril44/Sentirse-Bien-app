using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SentirseBien
{
    public partial class PagoForm : Form
    {
        private Usuario usuario = new Usuario();
        private Turno turno = new Turno();
        public PagoForm(Usuario usuario, Turno turno)
        {
            this.usuario = usuario;
            this.turno = turno;
            InitializeComponent();
        }

        private void aceptar_button_Click(object sender, EventArgs e)
        {
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

       
    }
}
