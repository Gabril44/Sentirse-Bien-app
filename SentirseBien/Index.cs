using Microsoft.VisualBasic.Devices;
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
            //panelContenedor.Visible = true;
            getRol(usuario);
            panelMenuPerfil.Visible = false;
            BienvenidoForm bienvenidoForm = new BienvenidoForm(usuario);
            AbrirFormularioEnPanel(bienvenidoForm);

        }
        private void getRol(Usuario usuario)
        {
            switch (usuario.rol)
            {
                case 0:
                    PanelButtomClientes.Visible = false;
                    label2.Visible = false;
                    panelPagos.Visible = false;
                    label5.Visible = false;
                    break;
                case 1:

                    if (usuario.correo == "test@gmail.com")
                    {

                    }
                    else
                    {
                        PanelButtomClientes.Visible = false;
                        label2.Visible = false;
                        panelPagos.Visible = false;
                        label5.Visible = false;
                    }
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
            //MessageBox.Show("apretaste turnos");
            Form1 turnos = new Form1(usuario);
            AbrirFormularioEnPanel(turnos);
            //this.Hide();
            //turnos.Show();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("apretaste clientes");
            Clientes clientes = new Clientes(usuario);
            AbrirFormularioEnPanel(clientes);
            /*this.Hide();
            clientes.ShowDialog();*/
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
            if (panelMenuPerfil.Visible)
            {
                panelMenuPerfil.Visible = false;
            };
        }

        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            //MessageBox.Show("llegó al metodo");
            if (panelContenedor.Controls.Count > 0)
            {
                //MessageBox.Show("Llegó al if");
                panelContenedor.Controls[0].Dispose();

                formularioHijo.TopLevel = false;
                formularioHijo.FormBorderStyle = FormBorderStyle.None;
                formularioHijo.Dock = DockStyle.Fill;

                panelContenedor.Controls.Add(formularioHijo);
                panelContenedor.Tag = formularioHijo;
                formularioHijo.Show();


            }
            else
            {
                //MessageBox.Show("Llegó al Else");

                panelContenedor.Controls.Clear();

                formularioHijo.TopLevel = false;
                formularioHijo.FormBorderStyle = FormBorderStyle.None;
                formularioHijo.Dock = DockStyle.Fill;

                panelContenedor.Controls.Add(formularioHijo);
                panelContenedor.Tag = formularioHijo;
                formularioHijo.Show();
            }
        }

        /* private void abrirFormHijo(Form formhijo)
         {
             try
             {
                 if (this.panelContenedor.Controls.Count > 0)
                 {
                     this.panelContenedor.Controls.RemoveAt(0);
                     formhijo.TopLevel = false;
                     formhijo.Dock = DockStyle.Fill;
                     this.panelContenedor.Controls.Add(formhijo);
                     this.panelContenedor.Tag = formhijo;
                     formhijo.Show();
                     panelContenedor.Refresh();
                     MessageBox.Show("Formulario añadido exitosamente");
                 }
             }
             catch (Exception ex) 
             {
                 MessageBox.Show("Error :"+ex.Message);
             }
         }*/

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BienvenidoForm bienvenidoForm = new BienvenidoForm(usuario);
            AbrirFormularioEnPanel(bienvenidoForm);
        }
    }
}
