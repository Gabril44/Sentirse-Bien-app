using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
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
        private ConexionMysql conexionMysql;
        private List<Pago> pagos;
        public Index(Usuario usuario)
        {
            this.usuario = usuario;
            conexionMysql = new ConexionMysql();
            pagos = new List<Pago>();
            InitializeComponent();
            //configurarMenuStrip(usuario);
            //panelContenedor.Visible = true;
            getRol(usuario);
            ActualizarLabelPagosPendientes();
            BienvenidoForm bienvenidoForm = new BienvenidoForm(usuario);
            AbrirFormularioEnPanel(bienvenidoForm);
        }

        private void ActualizarLabelPagosPendientes()
        {
            if (ContarPagosPendientes(usuario) > 0)
            {
                label_turnosapagar.Visible = true;
            }

        }

        private int ContarPagosPendientes(Usuario usuario)
        {
            int pagos_pendientes = 0;

            try
            {
                using (MySqlConnection connection = conexionMysql.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM pagos WHERE id_usuario = @usuarioId AND estado = 'pendiente'";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@usuarioId", usuario.idusuario);
                        pagos_pendientes = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return pagos_pendientes;
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
                    panelServicios.Visible = false;
                    label_servicios.Visible = false;

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
                        panelServicios.Visible = false;
                        label_servicios.Visible = false;
                        panel_pagar.Visible = false;
                        label_pagar.Visible = false;
                    }
                    break;
            }
        }


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
            ActualizarLabelPagosPendientes();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("apretaste clientes");
            Clientes clientes = new Clientes(usuario);
            AbrirFormularioEnPanel(clientes);
            /*this.Hide();
            clientes.ShowDialog();*/
            ActualizarLabelPagosPendientes();
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
        private void index_Click(object sender, EventArgs e)
        {

        }

       

        private void panelCerrar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }


        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
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
                if (formularioHijo is Form1 hijo)
                {
                    hijo.CambioRealizado += Hijo_CambioRealizado;
                }

                ActualizarLabelPagosPendientes();
            }
            finally
            {
                // Asegurarse de restaurar el cursor normal
                Cursor.Current = Cursors.Default;
            }

        }

        public void Hijo_CambioRealizado(object sender, EventArgs e)
        {
            // Llamamos al método que necesitamos
            ActualizarLabelPagosPendientes();
        }



        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BienvenidoForm bienvenidoForm = new BienvenidoForm(usuario);
            AbrirFormularioEnPanel(bienvenidoForm);
            ActualizarLabelPagosPendientes();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Index_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Pagos_Click(object sender, MouseEventArgs e)
        {
            PagosForm pagosForm = new PagosForm(usuario);
            AbrirFormularioEnPanel(pagosForm);
            ActualizarLabelPagosPendientes();
        }

        private void panelServicios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void serviciosClick(object sender, MouseEventArgs e)
        {
            ServiciosForm serviciosForm = new ServiciosForm(usuario);
            AbrirFormularioEnPanel(serviciosForm);
            ActualizarLabelPagosPendientes();
        }

        private void ClickPagar(object sender, MouseEventArgs e)
        {

            SeleccionAPagar seleccionAPagar = new SeleccionAPagar(usuario);
            seleccionAPagar.PagoRealizado += SeleccionAPagar_PagoRealizado;
            AbrirFormularioEnPanel(seleccionAPagar);
            ActualizarLabelPagosPendientes();
        }
        private void SeleccionAPagar_PagoRealizado(object sender, EventArgs e)
        {
            // Aquí puedes llamar cualquier método del formulario principal
            ActualizarLabelPagosPendientes();  // Este método se llama cuando se realiza un pago
        }

        
    }
}
