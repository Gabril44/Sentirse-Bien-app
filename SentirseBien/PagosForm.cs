using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentirseBien
{
    public partial class PagosForm : Form
    {
        private Pago pago;
        private List<Pago> pagos;
        private PagosConsulta pagosconsulta;
        private Usuario usuario;
        public PagosForm(Usuario usuario)
        {
            InitializeComponent();
            pagos = new List<Pago>();
            pagosconsulta = new PagosConsulta();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cargarPagos();
                this.usuario = usuario;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void cargarPagos(string filtro = "")
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            pagos.Clear();
            pagos = pagosconsulta.getPago(filtro);

            for (int i = 0; i < pagos.Count; i++)
            {
                dataGridView1.RowTemplate.Height = 50;
                dataGridView1.Rows.Add(
                    pagos[i].nropago,
                    pagos[i].monto,
                    pagos[i].nombre_cliente,
                    pagos[i].fecha,
                    pagos[i].medio_de_pago,
                    pagos[i].estado,
                    pagos[i].id_usuario,
                    pagos[i].fechalimite,
                    pagos[i].servicio,
                    pagos[i].profesional
                    );
            }

        }

        private void imprimir_button_Click(object sender, EventArgs e)
        {
            // Crear el documento PDF
            Document doc = new Document(PageSize.LETTER, 10, 10, 10, 10);

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
                    // Crear el archivo en la ruta seleccionada
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    doc.Open();

                    // Agregar un título
                    Paragraph title = new Paragraph("Reporte de Pagos", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK))
                    {
                        Alignment = Element.ALIGN_CENTER
                    };
                    doc.Add(title);
                    doc.Add(Chunk.NEWLINE);

                    // Crear la tabla en el PDF (con la misma cantidad de columnas que el DataGridView)
                    PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                    pdfTable.WidthPercentage = 100; // Ancho de la tabla
                    pdfTable.SpacingBefore = 10f;
                    pdfTable.SpacingAfter = 10f;

                    // Agregar las cabeceras de las columnas
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText))
                        {
                            BackgroundColor = BaseColor.LIGHT_GRAY
                        };
                        pdfTable.AddCell(headerCell);
                    }

                    // Agregar las filas del DataGridView al PDF
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue; // Ignorar la última fila en blanco

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value?.ToString() ?? ""); // Agregar las celdas a la tabla
                        }
                    }

                    // Agregar la tabla al documento
                    doc.Add(pdfTable);

                    MessageBox.Show("PDF generado exitosamente en: " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message);
                }
                finally
                {
                    doc.Close(); // Cerrar el documento PDF
                }
            }
        }
    }
}
