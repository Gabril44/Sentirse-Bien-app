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
    public partial class AgregarServicioForm : Form
    {
        ConexionMysql conexionMysql;
        public AgregarServicioForm()
        {
            conexionMysql = new ConexionMysql();
            InitializeComponent();
        }

        private void aceptar_button_Click(object sender, EventArgs e)
        {
            string nombre = nombre_textbox.Text;
            int precio;
            bool esNumeroValido = int.TryParse(precio_textbox.Text, out precio);
            if (esNumeroValido)
            {
                if (precio > 0)
                {
                    string QUERY = "INSERT INTO servicios (nombre, precio) VALUES (@nombre, @precio)";
                    using (MySqlConnection connection = new ConexionMysql().GetConnection())
                    {
                        try
                        {
                            // Crear el comando MySQL con parámetros
                            MySqlCommand cmd = new MySqlCommand(QUERY, connection);

                            // Agregar los parámetros a la consulta
                            cmd.Parameters.AddWithValue("@nombre", nombre);
                            cmd.Parameters.AddWithValue("@precio", precio);

                            // Ejecutar la consulta
                            int result = cmd.ExecuteNonQuery();

                            // Verificar si se insertó correctamente
                            if (result > 0)
                            {
                                MessageBox.Show("Servicio creado exitosamente.");
                            }
                            else
                            {
                                MessageBox.Show("Hubo un problema al crear el servicio.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
                else 
                {
                    MessageBox.Show("Debe ser mayor a 0!");
                }
            }

            else 
            {
                MessageBox.Show("ingrese un valor numérico válido");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
