using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        //private decimal precio_label;
        List<decimal> montos = new List<decimal>();
        List<Pago> pagos = new List<Pago>();
        List<Pago> pagosSeleccionados = new List<Pago>();
        public SeleccionAPagar(Usuario usuario)
        {
            this.usuario = usuario;
            conexionMysql = new ConexionMysql();
            InitializeComponent();
            //precio_label = 0;
            RellenarCheckBox();
            CargarDatos();
        }

        private void RellenarCheckBox()
        {
            checkedListBox1.Items.Clear();
            string QUERY = "SELECT estado, servicio, profesional FROM pagos";
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
                                if (reader.GetString("estado") == "pendiente") 
                                {

                                    checkedListBox1.Items.Add(reader.GetString("servicio") + "  por: " + reader.GetString("profesional"));
                                }
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

        private void CargarDatos()
        {
            string QUERY = "SELECT numeropago, monto, nombrecliente, fecha, mediodepago, id_usuario, fechalimite, servicio, profesional FROM pagos WHERE id_usuario = @id_usuario";

            using (MySqlConnection connection = conexionMysql.GetConnection())
            {
                MySqlCommand command = new MySqlCommand(QUERY, connection);
                command.Parameters.AddWithValue("@id_usuario", usuario.idusuario);

                try
                {
                    //connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pago pago = new Pago();
                            pago.nropago = reader.GetInt32("numeropago");
                            pago.monto = reader.GetDecimal("monto");
                            pago.nombre_cliente = reader.GetString("nombrecliente");
                            pago.fecha = reader.GetString("fecha");
                            pago.medio_de_pago = reader.GetString("mediodepago");
                            pago.id_usuario = reader.GetInt32("id_usuario");
                            pago.fechalimite = reader.GetString("fechalimite");
                            pago.servicio = reader.GetString("servicio");
                            pago.profesional = reader.GetString("profesional");
                            pagos.Add(pago);
                            // Agrega el monto a la lista
                            decimal monto = reader.GetDecimal("monto");
                            montos.Add(monto);

                            // Agrega un ítem al CheckedListBox (aquí asumes que también tienes algún nombre para mostrar)
                            //checkedListBox1.Items.Add($"Ítem {montos.Count} - {monto}"); // Cambia "Ítem {montos.Count}" según lo que desees mostrar
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }
        private void CheckedListBox1Changed(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked || e.NewValue == CheckState.Unchecked)
            {
                decimal montoSeleccionado = 0;

                // Verifica el índice del ítem que está cambiando
                int index = e.Index;

                // Asegúrate de que el índice sea válido
                if (index >= 0 && index < montos.Count)
                {
                    // Obtén el monto del ítem correspondiente al índice
                    montoSeleccionado = montos[index];
                    Pago pagoSeleccionado = pagos[index];
                    // Ajusta el valor del label_precio según el estado del checkbox
                    if (e.NewValue == CheckState.Checked)
                    {
                        pagosSeleccionados.Add(pagoSeleccionado);
                        MessageBox.Show("se agregó el pago: "+pagoSeleccionado.nropago+" a la list de pagos seleccionados");
                        label_precio.Text = (Decimal.Parse(label_precio.Text) + montoSeleccionado).ToString();
                    }
                    else if (e.NewValue == CheckState.Unchecked)
                    {
                        pagosSeleccionados.Remove(pagoSeleccionado);
                        MessageBox.Show("se quitó el pago: " + pagoSeleccionado.nropago + " de la list de pagos seleccionados");
                        label_precio.Text = (Decimal.Parse(label_precio.Text) - montoSeleccionado).ToString();
                    }
                }
            }

        }

        private void pagar_button_Click(object sender, EventArgs e)
        {
            PagoForm pagoForm = new PagoForm(usuario, Decimal.Parse(label_precio.Text), pagosSeleccionados);
            if (pagoForm.ShowDialog() == DialogResult.OK)
            {
                RellenarCheckBox();
                CargarDatos();
            }
        }
    }
}
