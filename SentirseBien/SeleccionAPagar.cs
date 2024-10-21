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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SentirseBien
{
    public partial class SeleccionAPagar : Form
    {
        private Usuario usuario;
        private ConexionMysql conexionMysql;
        public SeleccionAPagar(Usuario usuario)
        {
            this.usuario = usuario;
            conexionMysql = new ConexionMysql();
            InitializeComponent();
            RellenarCheckBox();
        }

        private void RellenarCheckBox()
        {
            checkedListBox1.Items.Clear();
            string QUERY = "SELECT servicio, profesional FROM pagos";
            using (MySqlConnection connection = conexionMysql.GetConnection())
            {
                MySqlCommand command = new MySqlCommand(QUERY, connection);

                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            {
                                checkedListBox1.Items.Add(reader.GetString("servicio") + "  por: " + reader.GetString("profesional"));
                            };

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }

        private void CheckedListBox1Changed(object sender, EventArgs e)
        {
            
        }

        private void CheckedListBox1Changed(object sender, ItemCheckEventArgs e)
        {
            string QUERY = "SELECT monto FROM pagos";
            using (MySqlConnection connection = conexionMysql.GetConnection())
            {
                MySqlCommand command = new MySqlCommand(QUERY, connection);

                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            {
                                label_precio.Text = (Decimal.Parse(label_precio.Text) + reader.GetDecimal("monto")).ToString();
                            };

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }
    }
}
