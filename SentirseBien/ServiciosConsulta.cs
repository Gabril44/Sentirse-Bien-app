using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentirseBien
{
    internal class ServiciosConsulta
    {
        private ConexionMysql conexionMysql;
        private List<Servicio> servicios;


        public ServiciosConsulta() 
        {
            conexionMysql = new ConexionMysql();
            servicios = new List<Servicio>();
        }

        public List<Servicio> getServicio(string filtro)
        {
            string QUERY = "SELECT * FROM servicios";
            MySqlDataReader reader = null;
            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                        "nombre LIKE '%" + filtro + "%' OR " +
                        "precio LIKE '%" + filtro + "%' OR " +
                        "numServicio LIKE '%" + filtro + "%';";
                }

                MySqlCommand comando = new MySqlCommand(QUERY);
                comando.Connection = conexionMysql.GetConnection();
                reader = comando.ExecuteReader();

                Servicio servicio = null;
                while (reader.Read())
                {
                    servicio = new Servicio();
                    servicio.nombre = reader.GetString("nombre");
                    servicio.precio = reader.GetInt32("precio");
                    servicio.num_servicio = reader.GetInt32("numServicio");
                    servicios.Add(servicio);
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return servicios;
        }
    }
}
