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
        private string fechafiltro;
        private string textofiltro;
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

                    // Agregar el logo (opcional)
                    string logoPath = "SentirseBien.Resources.logo.jpg"; // Ruta del logo embebido
                    using (var stream = typeof(PagoForm).Assembly.GetManifestResourceStream(logoPath))
                    {
                        if (stream != null)
                        {
                            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(stream);
                            logo.ScaleToFit(50, 50); // Tamaño del logo
                            logo.Alignment = iTextSharp.text.Image.ALIGN_LEFT;
                            doc.Add(logo);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la imagen embebida.");
                            return; // Salir si no se encuentra la imagen
                        }
                    }

                    // Agregar un título centrado
                    Paragraph title = new Paragraph("Reporte de Pagos", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK))
                    {
                        Alignment = Element.ALIGN_CENTER
                    };
                    doc.Add(title);
                    doc.Add(Chunk.NEWLINE);

                    // Información de la empresa
                    Paragraph infoEmpresa = new Paragraph("Sentirse Bien Spa\nDirección: Calle Falsa 123\nTel: +123456789")
                    {
                        Alignment = Element.ALIGN_LEFT,
                        Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
                    };
                    doc.Add(infoEmpresa);
                    doc.Add(Chunk.NEWLINE);

                    // Crear la tabla en el PDF, excluyendo la columna Id_usuario
                    PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count - 1)
                    {
                        WidthPercentage = 100, // Ancho de la tabla
                        SpacingBefore = 10f,
                        SpacingAfter = 10f
                    };

                    // Agregar las cabeceras de las columnas, excluyendo Id_usuario
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        if (column.Name != "id_usuario") // Asegurarse de que no se incluya Id_usuario
                        {
                            PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK)))
                            {
                                BackgroundColor = BaseColor.LIGHT_GRAY,
                                HorizontalAlignment = Element.ALIGN_CENTER
                            };
                            pdfTable.AddCell(headerCell);
                        }
                    }

                    // Agregar las filas del DataGridView al PDF, excluyendo Id_usuario
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue; // Ignorar la última fila en blanco

                        // Agregar las celdas, asegurándose de omitir Id_usuario
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            if (column.Name != "id_usuario") // Asegurarse de que no se incluya Id_usuario
                            {
                                PdfPCell cellData = new PdfPCell(new Phrase(row.Cells[column.Index].Value?.ToString() ?? "", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)))
                                {
                                    HorizontalAlignment = Element.ALIGN_CENTER
                                };
                                pdfTable.AddCell(cellData);
                            }
                        }
                    }

                    // Agregar la tabla al documento
                    doc.Add(pdfTable);

                    // Pie de página con la fecha de generación
                    Paragraph footer = new Paragraph("Generado el: " + DateTime.Now.ToString("dd/MM/yyyy"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.ITALIC, BaseColor.GRAY))
                    {
                        Alignment = Element.ALIGN_RIGHT
                    };
                    doc.Add(footer);

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

        private void FiltrarFechaClick(object sender, EventArgs e)
        {
            CalendarioForm calendarioForm = new CalendarioForm();
            if (calendarioForm.ShowDialog() == DialogResult.OK)
            {
                this.fechafiltro = calendarioForm.fecha;
                try
                {
                    string filtro = "";
                    // Mostrar el cursor de espera
                    Cursor.Current = Cursors.WaitCursor;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    pagos.Clear();
                    pagos = pagosconsulta.getPago(filtro);

                    for (int i = 0; i < pagos.Count; i++)
                    {
                        if (DateTime.Parse(pagos[i].fecha).Date == DateTime.Parse(this.fechafiltro).Date)
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
                }
                finally
                {
                    // Asegurarse de restaurar el cursor normal
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void FiltrarProfesionalClick(object sender, EventArgs e)
        {
            TextoForm textoForm = new TextoForm();
            if (textoForm.ShowDialog() == DialogResult.OK)
            {
                textofiltro = textoForm.texto;
                string filtro = "";
                try
                {
                    // Mostrar el cursor de espera
                    Cursor.Current = Cursors.WaitCursor;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    pagos.Clear();
                    pagos = pagosconsulta.getPago(filtro);

                    for (int i = 0; i < pagos.Count; i++)
                    {
                        if (pagos[i].profesional == textofiltro)
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
                }
                finally
                {
                    // Asegurarse de restaurar el cursor normal
                    Cursor.Current = Cursors.Default;
                }

            }
        }

        private void FiltrarClienteClick(object sender, EventArgs e)
        {
            TextoForm textoForm = new TextoForm();
            if (textoForm.ShowDialog() == DialogResult.OK)
            {
                textofiltro = textoForm.texto;
                string filtro = "";
                try
                {
                    // Mostrar el cursor de espera
                    Cursor.Current = Cursors.WaitCursor;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    pagos.Clear();
                    pagos = pagosconsulta.getPago(filtro);

                    for (int i = 0; i < pagos.Count; i++)
                    {
                        if (pagos[i].nombre_cliente == textofiltro)
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
                }
                finally
                {
                    // Asegurarse de restaurar el cursor normal
                    Cursor.Current = Cursors.Default;
                }

            }
        }

        private void MediodePagoClick(object sender, EventArgs e)
        {
            TextoForm textoForm = new TextoForm();
            if (textoForm.ShowDialog() == DialogResult.OK)
            {
                textofiltro = textoForm.texto;
                string filtro = "";
                try
                {
                    // Mostrar el cursor de espera
                    Cursor.Current = Cursors.WaitCursor;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    pagos.Clear();
                    pagos = pagosconsulta.getPago(filtro);

                    for (int i = 0; i < pagos.Count; i++)
                    {
                        if (pagos[i].medio_de_pago == textofiltro)
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
                }
                finally
                {
                    // Asegurarse de restaurar el cursor normal
                    Cursor.Current = Cursors.Default;
                }

            }
        }
    }
}
