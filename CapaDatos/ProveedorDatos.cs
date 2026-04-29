using CapaEntidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ProveedorDatos
    {
        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new();

            using (SqlConnection cn = AccesoDatos.Connection())
            {
                SqlCommand cmd = new SqlCommand("sp_Proveedor_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Proveedor
                    {
                        ProveedorID = (int)dr["ProveedorID"],
                        Nombre = dr["Nombre"].ToString(),
                    });
                }
            }

            return lista;
        }
    }
    public class PoliticaImpuestoDatos
    {
        public List<PoliticaImpuesto> Listar()
        {
            List<PoliticaImpuesto> lista = new();

            using (SqlConnection cn = AccesoDatos.Connection())
            {
                SqlCommand cmd = new SqlCommand("sp_PoliticaImpuesto_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new PoliticaImpuesto
                    {
                        PoliticaID = (int)dr["PoliticaID"],
                        Nombre = dr["Nombre"].ToString(),
                        TasaImpuesto = (decimal)dr["TasaImpuesto"],
                        Descripcion = dr["Descripcion"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}
