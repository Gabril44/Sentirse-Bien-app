using MySql.Data.MySqlClient.Memcached;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentirseBien
{
    internal class PagosConsulta
    {
        private ConexionMysql conexionMysql;
        private List<Pago> pagos;

        public PagosConsulta()
        {
            conexionMysql = new ConexionMysql();
            pagos = new List<Pago>();
        }

        public List<Pago> getPago(string filtro)
        {
            string QUERY = "SELECT * FROM pagos";
            MySqlDataReader reader = null;
            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                        "numeropago LIKE '%" + filtro + "%' OR " +
                        "monto LIKE '%" + filtro + "%' OR " +
                        "nombrecliente LIKE '%" + filtro + "%' OR " +
                        "fecha LIKE '%" + filtro + "%' OR " +
                        "mediodepago LIKE '%" + filtro + "%' OR " +
                        "estado LIKE '%" + filtro + "%' OR " +
                        "id_usuario LIKE '%" + filtro + "%' OR " +
                        "fechalimite LIKE '%" + filtro + "%' OR " +
                        "servicio LIKE '%" + filtro + "%';";
                }

                MySqlCommand comando = new MySqlCommand(QUERY);
                comando.Connection = conexionMysql.GetConnection();
                reader = comando.ExecuteReader();

                Pago pago = null;
                while (reader.Read())
                {
                    pago = new Pago();
                    pago.nropago = reader.GetInt16("numeropago");
                    pago.monto = reader.GetDecimal("monto");
                    pago.nombre_cliente = reader.GetString("nombrecliente");
                    pago.fecha = reader.GetString("fecha");
                    pago.medio_de_pago = reader.GetString("mediodepago");
                    pago.estado = reader.GetString("estado");
                    pago.id_usuario = reader.GetInt16("id_usuario");
                    pago.fechalimite = reader.GetString("fechalimite");
                    pago.servicio = reader.GetString("servicio");
                    pago.profesional = reader.GetString("profesional");
                    pagos.Add(pago);
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return pagos;
        }


    }
}
