using CapaEntidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public partial class AccesoDatos
    {
        public class CategoriaDatos
        {
            public List<CategoriaArticulo> ListarCategorias()
            {
                List<CategoriaArticulo> lista = new List<CategoriaArticulo>();

                using (SqlConnection con = AccesoDatos.Connection())
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarCategorias", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CategoriaArticulo categoria = new CategoriaArticulo()
                            {
                                CategoriaID = Convert.ToInt32(dr["CategoriaID"]),
                                Nombre = dr["Nombre"].ToString(),
                                Descripcion = dr["Descripcion"].ToString()
                            };

                            lista.Add(categoria);
                        }
                    }
                }

                return lista;
            }
        }
    }

}
