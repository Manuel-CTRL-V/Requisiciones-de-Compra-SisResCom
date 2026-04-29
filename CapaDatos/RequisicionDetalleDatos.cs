using CapaEntidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class RequisicionDetalleDatos
    {

        /// <summary>
        /// Inserta múltiples detalles en una transacción
        /// </summary>
        public void InsertarDetalles(int requisicionID, List<RequisicionDetalle> detalles)
        {
            using (SqlConnection conn = AccesoDatos.Connection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    foreach (var detalle in detalles)
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_RequisicionDetalle_Insertar", conn, transaction))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@RequisicionID", requisicionID);
                            cmd.Parameters.AddWithValue("@ArticuloID", detalle.oArticuloID.ArticuloID);
                            cmd.Parameters.AddWithValue("@ProveedorID", detalle.oProveedorID.ProveedorID);
                            cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                            cmd.Parameters.AddWithValue("@SubTotal", detalle.Subtotal);
                            cmd.Parameters.AddWithValue("@PoliticaImpuestoID", detalle.oPoliticaImpuestoID.PoliticaID);
                            cmd.Parameters.AddWithValue("@Impuesto", detalle.Impuesto);
                            cmd.Parameters.AddWithValue("@Total", detalle.Total);
                            cmd.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario);

                            SqlParameter outputParam = new SqlParameter("@DetalleID", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.Output
                            };
                            cmd.Parameters.Add(outputParam);

                            cmd.ExecuteNonQuery();

                            detalle.DetalleID = (int)cmd.Parameters["@DetalleID"].Value;
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception($"Error al insertar detalles de requisición: {ex.Message}", ex);
                }
            }
        }

        /// <summary>
        /// Obtiene todos los detalles de una requisición
        /// </summary>
        public List<RequisicionDetalle> ObtenerDetallesPorRequisicion(int requisicionID)
        {
            List<RequisicionDetalle> detalles = new List<RequisicionDetalle>();

            using (SqlConnection conn = AccesoDatos.Connection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_RequisicionDetalle_ObtenerPorRequisicion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RequisicionID", requisicionID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                RequisicionDetalle detalle = new RequisicionDetalle
                                {
                                    DetalleID = (int)reader["DetalleID"],
                                    oRequisicionID = new Requisicion() { RequisicionID = (int)reader["RequisicionID"] },
                                    oArticuloID = new Articulo() { ArticuloID = (int)reader["ArticuloID"] },
                                    oProveedorID = new Proveedor() { ProveedorID = (int)reader["ProveedorID"] },
                                    Cantidad = (decimal)reader["Cantidad"],
                                    PrecioUnitario = (decimal)reader["PrecioUnitario"],
                                    oPoliticaImpuestoID = new PoliticaImpuesto() { PoliticaID = (int)reader["PoliticaImpuestoID"] }
                                };

                                detalles.Add(detalle);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception($"Error al obtener detalles de requisición: {ex.Message}", ex);
                    }
                }
            }
            return detalles;
        }
    }
}
