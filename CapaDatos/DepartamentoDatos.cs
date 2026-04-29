using CapaEntidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DepartamentoDatos
    {
        public List<Departamento> Listar()
        {
            List<Departamento> lista = new();

            using (SqlConnection cn = AccesoDatos.Connection())
            {
                SqlCommand cmd = new SqlCommand("sp_Departamento_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Departamento
                    {
                        DepartamentoID = (int)dr["DepartamentoID"],
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        Activo = (bool)dr["Activo"]
                    });
                }
            }
            return lista;
        }
    }
}
