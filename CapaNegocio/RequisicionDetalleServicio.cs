using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class RequisicionDetalleServicio
    {
        private readonly RequisicionDetalleDatos datos = new();

        public List<RequisicionDetalle> ListarPorRequisicion(int idRequisicion)
        {
            return datos.ObtenerDetallesPorRequisicion(idRequisicion);
        }
    }
}
