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
    public partial class pedirTurno : Form
    {
        private string fecha;
        private ConexionMysql conexionMysql;
        public pedirTurno()
        {
            InitializeComponent();
            conexionMysql = new ConexionMysql();
            loadComboBoxItems();
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

        private void aceptar_button_Click(object sender, EventArgs e)
        {
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
