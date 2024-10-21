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
    }
}
