using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SentirseBien
{
    public partial class ServiciosForm : Form
    {
        private Servicio servicio;
        private List<Servicio> servicios;
        private ServiciosConsulta servicioconsulta;
        private Usuario usuario;
        public ServiciosForm(Usuario usuario)
        {
            InitializeComponent();
            servicios = new List<Servicio>();
            servicioconsulta = new ServiciosConsulta();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cargarServicios();
                this.usuario = usuario;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void cargarServicios(string filtro ="")
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            servicios.Clear();
            servicios = servicioconsulta.getServicio(filtro);

            for (int i = 0; i < servicios.Count; i++)
            {
                dataGridView1.RowTemplate.Height = 50;
                dataGridView1.Rows.Add(
                    servicios[i].nombre,
                    servicios[i].precio,
                    servicios[i].num_servicio
                    );
            }
        }
    }
}
