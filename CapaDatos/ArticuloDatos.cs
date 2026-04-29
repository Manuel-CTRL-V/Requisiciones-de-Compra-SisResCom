using CapaEntidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ArticuloDatos
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new();

            using (SqlConnection cn = AccesoDatos.Connection())
            {
                SqlCommand cmd = new SqlCommand("sp_Articulo_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Articulo
                    {
                        ArticuloID = (int)dr["ArticuloID"],
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        UnidadMedida = dr["UnidadMedida"].ToString(),
                        PrecioReferencia = Convert.ToDecimal(dr["PrecioReferencia"]),
                        oCategoriaArticulo = new CategoriaArticulo() { CategoriaID = Convert.ToInt32(dr["CategoriaID"]) },
                        Activo = Convert.ToBoolean(dr["Activo"])
                    });
                }
            }

            return lista;
        }
    }
}
