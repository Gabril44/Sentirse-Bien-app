using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentirseBien
{
    internal class TurnoConsultas
    {
        private ConexionMysql conexionMysql;
        private List<Turno> turnos;

        public TurnoConsultas()
        {
            conexionMysql = new ConexionMysql();
            turnos = new List<Turno>();
        }

        public List<Turno> getTurno(string filtro)
        {
            List<Turno> turnos = new List<Turno>(); // Inicializa la lista
            string QUERY = "SELECT * FROM turnos";

            try
            {
                if (!string.IsNullOrEmpty(filtro)) // Verifica si el filtro no está vacío o es nulo
                {
                    QUERY += " WHERE " +
                        "idturno LIKE '%" + filtro + "%' OR " +
                        "nombre_usuario LIKE '%" + filtro + "%' OR " +
                        "fecha LIKE '%" + filtro + "%' OR " +
                        "servicio LIKE '%" + filtro + "%' OR " +
                        "profesional LIKE '%" + filtro + "%';";
                }

                using (MySqlConnection connection = conexionMysql.GetConnection()) // Usar 'using' para manejar la conexión
                {
                    // Verificar si la conexión está cerrada antes de abrirla
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open(); // Abre la conexión solo si está cerrada
                    }

                    MySqlCommand comando = new MySqlCommand(QUERY, connection); // Asocia el comando a la conexión
                    using (MySqlDataReader reader = comando.ExecuteReader()) // Usar 'using' para manejar el reader
                    {
                        while (reader.Read())
                        {
                            Turno turno = new Turno();
                            turno.idturnos = reader.GetInt16("idturnos");
                            turno.nombre_usuario = reader.GetString("nombre_usuario");
                            turno.fecha = reader.GetString("fecha");
                            turno.servicio = reader.GetString("servicio");
                            turno.profesional = reader.GetString("profesional");
                            turnos.Add(turno);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los turnos: " + ex.Message);
                // O manejar la excepción de otra forma según tu lógica
            }

            return turnos;
        }

    }
}
