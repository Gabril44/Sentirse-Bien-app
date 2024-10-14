using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SentirseBien.ClientesConsulta;

namespace SentirseBien
{
    public partial class Clientes : Form
    {
        private Usuario usuario;
        private List<Usuario> clientes;
        private ClientesConsulta clientesConsulta;
        public Clientes(Usuario usuario)
        {
            InitializeComponent();
            clientes = new List<Usuario>();
            clientesConsulta = new ClientesConsulta();
            cargarClientes();
            this.usuario = usuario;
        }

       

        private void cargarClientes(string filtro = "")
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            clientes.Clear();
            clientes = clientesConsulta.getUsuario(filtro);

            for (int i = 0; i < clientes.Count; i++)
            {
                dataGridView1.RowTemplate.Height = 50;
                if (clientes[i].rol==0) 
                { 
                dataGridView1.Rows.Add(
                    clientes[i].idusuario,
                    clientes[i].nombre,
                    clientes[i].correo,
                    clientes[i].password,
                    clientes[i].user
                    );
                }
            }

        }
    }
}
