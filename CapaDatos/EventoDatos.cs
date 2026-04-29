using CapaEntidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class EventoDatos
    {
        public List<Evento> Listar()
        {
            List<Evento> lista = new();

            using (SqlConnection cn = AccesoDatos.Connection())
            {
                SqlCommand cmd = new SqlCommand("sp_Evento_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Evento
                    {
                        EventoId = (int)dr["EventoID"],
                        NombreEvento = dr["NombreEvento"].ToString(),
                    });
                }
            }

            return lista;
        }
    }
}
