using CapaEntidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class UsuarioDatos
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new();

            using (SqlConnection cn = AccesoDatos.Connection())
            {
                SqlCommand cmd = new SqlCommand("sp_Usuario_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Usuario
                    {
                        UsuarioID = Convert.ToInt32(dr["UsuarioID"]),
                        oEmpleado = new Empleado() { EmpleadoID = (Convert.ToInt32(dr["EmpleadoID"])) },
                        NombreUsuario = dr["NombreUsuario"].ToString(),
                        oRol = new Rol() { RolID = dr["RolId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["RolId"]) },
                        PasswordHash = dr["PasswordHash"].ToString(),
                        Activo = Convert.ToBoolean(dr["Activo"])
                    });
                }
            }

            return lista;
        }

        public void Insertar(Usuario usuario)
        {
            using (SqlConnection cn = AccesoDatos.Connection())
            {
                SqlCommand cmd = new SqlCommand("sp_Usuario_Insertar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpleadoID", usuario.oEmpleado.EmpleadoID);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@PasswordHash", usuario.PasswordHash);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Usuario usuario)
        {
            using (SqlConnection cn = AccesoDatos.Connection())
            {
                SqlCommand cmd = new SqlCommand("sp_Usuario_Actualizar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioID", usuario.UsuarioID);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@Activo", usuario.Activo);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void ActualizarAcceso(int usuarioID)
        {
            using (SqlConnection cn = AccesoDatos.Connection())
            {
                SqlCommand cmd = new SqlCommand(
                    "sp_Usuario_ActualizarUltimoAcceso",
                    cn
                );

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public Usuario ObtenerPorUsuario(string nombreUsuario)
        {
            Usuario usuario = null;

            using (SqlConnection cn = AccesoDatos.Connection())
            {
                SqlCommand cmd = new SqlCommand("sp_Usuario_PorNombre", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    usuario = new Usuario
                    {
                        UsuarioID = (int)dr["UsuarioID"],
                        oEmpleado = new Empleado() { EmpleadoID = (int)dr["EmpleadoID"] },
                        NombreUsuario = dr["NombreUsuario"].ToString(),
                        PasswordHash = dr["PasswordHash"].ToString(),
                        Activo = (bool)dr["Activo"]
                    };
                }
            }
            return usuario;
        }
    }
}
