using CapaEntidades;
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;

namespace CapaDatos
{
    public class RequisicionDatos
    {
        /// <summary>
        /// Lista todas las requisiciones en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Requisicion> Listar()
        {
            List<Requisicion> lista = new List<Requisicion>();

            using (Microsoft.Data.SqlClient.SqlConnection cn = AccesoDatos.Connection())
            {
                try
                {
                    Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand("sp_Requisicion_Listar", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Requisicion()
                            {
                                RequisicionID = Convert.ToInt32(dr["RequisicionID"]),
                                Referencia = dr["Referencia"].ToString(),
                                RemitenteID = Convert.ToInt32(dr["RemitenteID"]),
                                AprobadorID = dr["AprobadorID"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["AprobadorID"]),
                                DepartamentoDestinoID = Convert.ToInt32(dr["DepartamentoDestinoID"]),
                                oCodigoEvento = dr["CodigoEvento"] == DBNull.Value ? null : new Evento() { EventoId = Convert.ToInt32(dr["CodigoEvento"]), NombreEvento = dr["NombreEvento"].ToString() },
                                FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]),
                                FechaCaducidad = Convert.ToDateTime(dr["FechaCaducidad"]),
                                Observaciones = dr["Observaciones"].ToString(),
                                EstadoID = Convert.ToInt32(dr["EstadoID"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Requisicion>();
                }
            }
            return lista;
        }
        /// <summary>
        /// Actualiza la requisición y borra los detalles para actualizarlos
        /// </summary>
        /// <param name="requisicion">Requisición que se va a actualizar</param>
        public void ActualizarCompleta(Requisicion requisicion)
        {
            using (Microsoft.Data.SqlClient.SqlConnection conn = AccesoDatos.Connection())
            using (Microsoft.Data.SqlClient.SqlCommand cmd = new SqlCommand("sp_Requisicion_ActualizarCompleta", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RequisicionID", requisicion.RequisicionID);
                cmd.Parameters.AddWithValue("@Referencia", requisicion.Referencia);
                cmd.Parameters.AddWithValue("@RemitenteID", requisicion.RemitenteID);
                cmd.Parameters.AddWithValue("@AprobadorID", (object)requisicion.AprobadorID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DepartamentoDestinoID", requisicion.DepartamentoDestinoID);
                cmd.Parameters.AddWithValue("@CodigoEvento", (object)requisicion.oCodigoEvento == null ? DBNull.Value : requisicion.oCodigoEvento.EventoId);
                cmd.Parameters.AddWithValue("@NombreEvento", (object)requisicion.oCodigoEvento == null ? DBNull.Value : requisicion.oCodigoEvento.NombreEvento);
                cmd.Parameters.AddWithValue("@FechaCaducidad", requisicion.FechaCaducidad);
                cmd.Parameters.AddWithValue("@Observaciones", (object)requisicion.Observaciones ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EstadoID", requisicion.EstadoID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Inserta una nueva requisición en la base de datos
        /// </summary>
        public int InsertarRequisicion(Requisicion requisicion)
        {
            int requisicionID = requisicion.RequisicionID;

            using (SqlConnection conn = AccesoDatos.Connection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Requisicion_Insertar", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    cmd.Parameters.AddWithValue("@Referencia", requisicion.Referencia);
                    cmd.Parameters.AddWithValue("@RemitenteID", requisicion.RemitenteID);
                    cmd.Parameters.AddWithValue("@AprobadorID", (object)requisicion.AprobadorID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DepartamentoDestinoID", requisicion.DepartamentoDestinoID);
                    cmd.Parameters.AddWithValue("@CodigoEvento", requisicion.oCodigoEvento == null ? (object)DBNull.Value : requisicion.oCodigoEvento.EventoId);
                    cmd.Parameters.AddWithValue("@NombreEvento", requisicion.oCodigoEvento == null ? (object)DBNull.Value : requisicion.oCodigoEvento.NombreEvento);
                    cmd.Parameters.AddWithValue("@FechaCaducidad", requisicion.FechaCaducidad);
                    cmd.Parameters.AddWithValue("@Observaciones", requisicion.Observaciones ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@EstadoID", requisicion.EstadoID);

                    // Parámetro de salida
                    SqlParameter outputParam = new SqlParameter("@RequisicionID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        // Obtener el ID generado
                        requisicionID = (int)cmd.Parameters["@RequisicionID"].Value;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception($"Error al insertar requisición: {ex.Message}", ex);
                    }
                }
            }
            return requisicionID;
        }
        /// <summary>
        /// Obtiene las requisiciones aprobadas de la vista
        /// </summary>
        /// <returns>Lista con las requisiciones aprobadas</returns>
        public List<RequisicionAprobada> ObtenerRequisicionesAprobadas()
        {
            var requisiciones = new List<RequisicionAprobada>();

            using (var connection = AccesoDatos.Connection())
            {
                var command = new SqlCommand("SELECT * FROM vw_RequisicionesAprobadas", connection);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        requisiciones.Add(new RequisicionAprobada
                        {
                            RequisicionID = Convert.ToInt32(reader["RequisicionID"]),
                            Referencia = reader["Referencia"]?.ToString(),
                            Remitente = reader["Remitente"]?.ToString(),
                            Aprobador = reader["Aprobador"]?.ToString(),
                            DepartamentoDestino = reader["DepartamentoDestino"]?.ToString(),
                            CodigoEvento = reader["CodigoEvento"] == DBNull.Value ? "No especificado" : reader["CodigoEvento"].ToString(),
                            NombreEvento = reader["NombreEvento"] == DBNull.Value ? "No especificado" : reader["NombreEvento"].ToString(),
                            FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]),
                            FechaCaducidad = Convert.ToDateTime(reader["FechaCaducidad"]),
                            Observaciones = reader["Observaciones"] == DBNull.Value ? "Sin observaciones" : reader["Observaciones"].ToString()
                        });
                    }
                }
            }

            return requisiciones;
        }

        public int EnviarARevision(int requisicionID)
        {
            return EjecutarSP("sp_Requisicion_EnviarARevision", requisicionID);
        }

        public int Aprobar(int requisicionID, int aprobadorID)
        {
            using (SqlConnection conn = AccesoDatos.Connection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Requisicion_Aprobar", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RequisicionID", requisicionID);
                    cmd.Parameters.AddWithValue("@AprobadorID", aprobadorID);

                    conn.Open();
                    return cmd.ExecuteNonQuery(); // devuelve filas afectadas
                }
            }
        }
        

        public int Rechazar(int requisicionID)
        {
            return EjecutarSP("sp_Requisicion_Rechazar", requisicionID);
        }

        public int Cancelar(int requisicionID)
        {
            return EjecutarSP("sp_Requisicion_Cancelar", requisicionID);
        }

        private int EjecutarSP(string nombreSP, int requisicionID)
        {
            using (SqlConnection conn = AccesoDatos.Connection())
            {
                using (SqlCommand cmd = new SqlCommand(nombreSP, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RequisicionID", requisicionID);

                    conn.Open();
                    return cmd.ExecuteNonQuery(); // devuelve filas afectadas
                }
            }
        }
    }
}
