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
    public partial class Index : Form
    {
        private Usuario usuario;
        public Index(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            //configurarMenuStrip(usuario);
            welcome_label.Text = usuario.nombre.ToString();
            getRol(usuario);
            panelMenuPerfil.Visible = false;

        }
        private void getRol(Usuario usuario)
        {
            switch (usuario.rol)
            {
                case 0:
                    rol_label.Text = "Este usuario es un Cliente " + usuario.rol;
                    break;
                case 1:
                    rol_label.Text = "Este usuario es un Empleado " + usuario.rol;
                    break;
                case 2:
                    rol_label.Text = "Este usuario es un Secretario/a " + usuario.rol;
                    break;
                case 3:
                    rol_label.Text = "Este usuario es la Dra Felicidad!!!! omg!!! y tiene rol: " + usuario.rol;
                    break;
            }
        }

        /*private void configurarMenuStrip(Usuario usuario) 
        {
            if (usuario.correo == "test@gmail.com") 
            {
                menuStrip1.Visible = true;
            }
            else 
            {
                menuStrip1.Visible = false;
            }
        }*/

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 turnos = new Form1(usuario);
            this.Hide();
            turnos.ShowDialog();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes(usuario);
            this.Hide();
            clientes.ShowDialog();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }


        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void PanelPerfil_Click(object sender, EventArgs e)
        {
            panelMenuPerfil.Visible = !panelMenuPerfil.Visible;
        }

        private void panelCerrar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void index_Click(object sender, MouseEventArgs e)
        {
           if( panelMenuPerfil.Visible)
            {
                panelMenuPerfil.Visible = false;
            };
        }
    }
}
