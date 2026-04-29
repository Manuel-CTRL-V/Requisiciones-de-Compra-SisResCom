using CapaEntidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class PermisoDatos
    {
        public List<Permiso> ListarPorUsuario(int usuarioID)
        {
            List<Permiso> permisos = new();

            using (SqlConnection cn = AccesoDatos.Connection())
            {
                SqlCommand cmd = new SqlCommand(
                    "sp_Permiso_ListarPorUsuario",
                    cn
                );

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    permisos.Add(new Permiso
                    {
                        PermisoID = (int)dr["PermisoID"],
                        NombreMenu = dr["NombreMenu"].ToString()
                    });
                }
            }
            return permisos;
        }
    }
}
