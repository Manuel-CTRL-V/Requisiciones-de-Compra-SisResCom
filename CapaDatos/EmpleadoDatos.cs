using CapaEntidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class EmpleadoDatos
    {
        public List<Empleado> Listar()
        {
            List<Empleado> lista = new();

            using (SqlConnection cn = AccesoDatos.Connection())
            {
                SqlCommand cmd = new SqlCommand("sp_Empleado_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Empleado
                    {
                        EmpleadoID = (int)dr["EmpleadoID"],
                        Nombre = dr["Nombre"].ToString(),
                        Apellido = dr["Apellido"].ToString(),
                        Email = dr["Email"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        oDepartamento = new Departamento() { DepartamentoID = (int)dr["DepartamentoID"] },
                        Activo = (bool)dr["Activo"]
                    });
                }
            }

            return lista;
        }

        public void Insertar(Empleado empleado)
        {
            using (SqlConnection cn = AccesoDatos.Connection())
            {
                SqlCommand cmd = new SqlCommand("sp_Empleado_Insertar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("@Email", empleado.Email);
                cmd.Parameters.AddWithValue("@FechaContratacion", empleado.FechaContratacion);
                cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                cmd.Parameters.AddWithValue("@DepartamentoID", empleado.oDepartamento.DepartamentoID);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Empleado empleado)
        {
            using (SqlConnection cn = AccesoDatos.Connection())
            {
                SqlCommand cmd = new SqlCommand("sp_Empleado_Actualizar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpleadoID", empleado.EmpleadoID);
                cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("@Email", empleado.Email);
                cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                cmd.Parameters.AddWithValue("@DepartamentoID", empleado.oDepartamento.DepartamentoID);
                cmd.Parameters.AddWithValue("@Activo", empleado.Activo);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int empleadoID)
        {
            using (SqlConnection cn = AccesoDatos.Connection())
            {
                SqlCommand cmd = new SqlCommand("sp_Empleado_Eliminar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
