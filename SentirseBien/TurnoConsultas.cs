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
            string QUERY = "SELECT * FROM turnos";
            MySqlDataReader reader = null;
            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                        "idturno LIKE '%" + filtro + "%' OR " +
                        "nombre_usuario LIKE '%" + filtro + "%' OR " +
                        "fecha LIKE '%" + filtro + "%' OR " +
                        "servicio LIKE '%" + filtro + "%' OR" +
                        "profesional LIKE '%" + filtro + "%';"; 
                }

                MySqlCommand comando = new MySqlCommand(QUERY);
                comando.Connection = conexionMysql.GetConnection();
                reader = comando.ExecuteReader();

                Turno turno = null;
                while(reader.Read()) 
                {
                    turno = new Turno();
                    turno.idturnos = reader.GetInt16("idturnos");
                    turno.nombre_usuario = reader.GetString("nombre_usuario");
                    turno.fecha = reader.GetString("fecha");
                    turno.servicio = reader.GetString("servicio");
                    turno.profesional = reader.GetString("profesional");
                    turnos.Add(turno);
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return turnos;
        }
    }
}
