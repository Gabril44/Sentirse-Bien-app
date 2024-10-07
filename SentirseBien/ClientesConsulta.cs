using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentirseBien
{
    internal class ClientesConsulta
    {
        
            private ConexionMysql conexionMysql;
            private List<Usuario> clientes;

            public ClientesConsulta()
            {
                conexionMysql = new ConexionMysql();
                clientes = new List<Usuario>();
            }

            public List<Usuario> getUsuario(string filtro)
            {
                string QUERY = "SELECT * FROM usuarios";
                MySqlDataReader reader = null;
                try
                {
                    if (filtro != "")
                    {
                        QUERY += " WHERE " +
                            "idusuario LIKE '%" + filtro + "%' OR " +
                            "nombre LIKE '%" + filtro + "%' OR " +
                            "correo LIKE '%" + filtro + "%' OR " +
                            "password LIKE '%" + filtro + "%' OR" +
                            "rol LIKE '%" + filtro + "%' OR" +
                            "user LIKE '%" + filtro + "%';";
                    }

                    MySqlCommand comando = new MySqlCommand(QUERY);
                    comando.Connection = conexionMysql.GetConnection();
                    reader = comando.ExecuteReader();

                    Usuario cliente = null;
                    while (reader.Read())
                    {
                        cliente = new Usuario();
                        cliente.idusuario = reader.GetInt16("idusuario");
                        cliente.nombre = reader.GetString("nombre");
                        cliente.correo = reader.GetString("correo");
                        cliente.password = reader.GetString("password");
                        cliente.rol = reader.GetInt16("rol");
                        cliente.user = reader.GetString("user");
                        clientes.Add(cliente);
                    }
                    reader.Close();
                }
                catch (Exception)
                {

                    throw;
                }
                return clientes;
            }
        }
    
}
