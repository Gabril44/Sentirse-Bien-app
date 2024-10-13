using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class pedirTurno : Form
    {
        private string fecha;
        private ConexionMysql conexionMysql;
        private Turno turno;
        private Usuario usario;
        public pedirTurno(Usuario usuario)
        {
            this.usario = usuario;
            InitializeComponent();
            conexionMysql = new ConexionMysql();
            loadComboBoxItems();
            test_label.Text= usuario.nombre;
        }

        private void loadComboBoxItems()
        {
            servicios_combobox.Items.Clear();
            string QUERY = "SELECT nombre,numServicio  FROM servicios";
            using (MySqlConnection connection = conexionMysql.GetConnection()) 
            {
                MySqlCommand command = new MySqlCommand(QUERY, connection);

                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader()) 
                    {
                        while (reader.Read()) 
                        {
                            ComboBoxItem item = new ComboBoxItem 
                            {
                                id = reader.GetInt32("numServicio"),
                                nombre = reader.GetString("nombre")
                            };
                            servicios_combobox.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Error al cargar datos: "+ex.Message);
                }
            }

            profesional_combobox.Items.Clear();
            string QUERY2 = "SELECT nombre, idusuario FROM usuarios WHERE rol = 1";
            using (MySqlConnection connection = conexionMysql.GetConnection())
            {
                MySqlCommand command = new MySqlCommand(QUERY2, connection);

                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ComboBoxItem item = new ComboBoxItem
                            {
                                id = reader.GetInt32("idusuario"),
                                nombre = reader.GetString("nombre")
                            };
                            profesional_combobox.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }

        }

        private void crearTurno(string nombre_usuario, string fecha, string servicio, string profesional) 
        {
            turno = new Turno();
            turno.nombre_usuario = nombre_usuario;
            turno.fecha = fecha;
            turno.profesional = profesional;
            turno.servicio = servicio;
        }

        private void aceptar_button_Click(object sender, EventArgs e)
        {
            PagoForm pagoform = new PagoForm();
            pagoform.ShowDialog();
            

                crearTurno(usario.nombre, labelfecha.Text, servicios_combobox.Text, profesional_combobox.Text);
                string QUERYCREARTURNO = "INSERT INTO turnos (nombre_usuario, servicio, fecha, profesional) " +
                       "VALUES (@nombreUsuario, @servicio, @fecha, @profesional)";
                using (MySqlConnection connection = new ConexionMysql().GetConnection())
                {
                    try
                    {
                        // Crear el comando MySQL con parámetros
                        MySqlCommand cmd = new MySqlCommand(QUERYCREARTURNO, connection);

                        // Agregar los parámetros a la consulta
                        cmd.Parameters.AddWithValue("@nombreUsuario", turno.nombre_usuario);
                        cmd.Parameters.AddWithValue("@servicio", turno.servicio);
                        cmd.Parameters.AddWithValue("@fecha", turno.fecha);
                        cmd.Parameters.AddWithValue("@profesional", turno.profesional);

                        // Ejecutar la consulta
                        int result = cmd.ExecuteNonQuery();

                        // Verificar si se insertó correctamente
                        if (result > 0)
                        {
                            MessageBox.Show("Turno creado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("Hubo un problema al crear el turno.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                this.Close();
        }

        private void fecha_button_Click(object sender, EventArgs e)
        {
            CalendarioForm calendarioForm = new CalendarioForm();
            if(calendarioForm.ShowDialog() == DialogResult.OK) 
            {
                this.fecha = calendarioForm.fecha;
                labelfecha.Text = calendarioForm.fecha;
            }
        }
    }

    public class ComboBoxItem 
    {
        public int id {  get; set; }
        public string nombre { get; set; }
        public override string ToString() 
        {
            return nombre; //llamamos para mostrar el texto
        }
    }
}
