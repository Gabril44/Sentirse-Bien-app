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
    public partial class LoginForm : Form
    {
        /*
         *  roles:
            0 -> cliente : pedir y ver turnos
            1 -> empleado: ver sus turnos del día
            2 -> secretaria: ver los pagos q se realizan
            3 -> Dra Felicidad : todo
         */
        private ConexionMysql conexionMysql;
        Usuario usuario = null;
        public LoginForm()
        {
            conexionMysql = new ConexionMysql();
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void aceptar_button_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                this.Hide();
                string username, password;
                username = user_textbox.Text;
                password = pass_textbox.Text;
                login(username, password);
            }
            finally 
            { 
                // Asegurarse de restaurar el cursor normal
                Cursor.Current = Cursors.Default;
            }
            
        }

        private Usuario login(string username, string password)
        {
            string QUERY = "SELECT idusuario, nombre, correo,  password, rol, user FROM usuarios WHERE user = '" + username +"' AND password = '"+ password+"' ";
            MySqlDataReader reader = null;
            try
            {
                string comprobar_usuario;
                string comprobar_contraseña;
                MySqlCommand comando = new MySqlCommand(QUERY);
                comando.Connection = conexionMysql.GetConnection();
                reader = comando.ExecuteReader();

                /*
                while (reader.Read())
                {
                    comprobar_usuario = reader.GetString("user");
                    comprobar_contraseña = reader.GetString("password");
                    MessageBox.Show("usuario: " + comprobar_usuario + " password: " + comprobar_contraseña);
                    MessageBox.Show("usuario: " + username + " password: " + password);
                    if(comprobar_contraseña == password && comprobar_usuario == username) 
                    {
                        MessageBox.Show("ususario encontrado!");
                        usuario = new Usuario();
                        usuario.idusuario=reader.GetInt16("idusuario");
                        usuario.rol = reader.GetInt16("rol");
                        usuario.correo = reader.GetString("correo");
                        usuario.nombre = reader.GetString("nombre");
                        usuario.password = reader.GetString("password");
                        gotoIndex(usuario);
                    }
                    else 
                    {
                        MessageBox.Show("este usuario no existe!");
                        break;
                    }
                 
                }
                  */
                if(reader.Read()) 
                {
                    usuario = new Usuario();
                    usuario.idusuario = reader.GetInt16("idusuario");
                    usuario.correo = reader.GetString("correo");
                    usuario.rol = reader.GetInt32("rol");
                    usuario.nombre = reader.GetString("nombre");
                    usuario.password = reader.GetString("password");
                    //MessageBox.Show("bienvenido " + reader.GetString("nombre") + "!");
                    gotoIndex(usuario);
                }
                else
                {
                    MessageBox.Show("este usuario no existe!");
                    LoginForm loginForm = new LoginForm();
                    loginForm.ShowDialog();
                }
                reader.Close();
            }


            catch (Exception)
            {

                throw;
            }
            return usuario;

            /*Index index = new Index();
            index.ShowDialog();
            this.Close();*/
        }

        private void gotoIndex(Usuario usuario) 
        {
            Index index = new Index(usuario);
            index.ShowDialog();
        }

        private void verTurnos()
        {
            Form1 form = new Form1(usuario);
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
