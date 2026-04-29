using CapaDatos;
using CapaEntidades;
using System.Transactions;

namespace CapaNegocio
{
    public class RequisicionServicio
    {
        private readonly CapaDatos.RequisicionDatos _requisicionDatos;
        private readonly RequisicionDatos _datos = new();
        private readonly RequisicionDetalleDatos _detalleDatos;

        public RequisicionServicio()
        {
            _requisicionDatos = new CapaDatos.RequisicionDatos();
            _detalleDatos = new RequisicionDetalleDatos();
        }

        public List<Requisicion> Listar()
        {
            return _datos.Listar();
        }
        /// <summary>
        /// Crea la requisición, la inserta en la BD y sus detalles 
        /// </summary>
        /// <param name="requisicion">Requisición a crear</param>
        /// <returns>El ID de la requisición creada</returns>
        /// <exception cref="Exception">Debe agregar un item</exception>
        public int CrearRequisicion(Requisicion requisicion)
        {
            // Validaciones 
            if (requisicion.Detalles.Count == 0)
                throw new Exception("Debe agregar al menos un ítem");

            // Llamar a la capa de datos
            int requisicionID = _requisicionDatos.InsertarRequisicion(requisicion);
            _detalleDatos.InsertarDetalles(requisicionID, requisicion.Detalles);

            return requisicionID;
        }
        public List<RequisicionAprobada> ObtenerRequisicionesAprobadas()
        {
            return _datos.ObtenerRequisicionesAprobadas();
        }
        public void ActualizarRequisicion(Requisicion requisicion, List<RequisicionDetalle> detalles)
        {
            if (requisicion == null)
                throw new ArgumentNullException(nameof(requisicion));

            if (detalles == null || !detalles.Any())
                throw new Exception("La requisición debe tener al menos un detalle.");

            using (var scope = new TransactionScope())
            {
                // Actualiza encabezado y elimina detalles (SP)
                _requisicionDatos.ActualizarCompleta(requisicion);

                // Inserta nuevamente los detalles
                _detalleDatos.InsertarDetalles(requisicion.RequisicionID, detalles);

                scope.Complete();
            }
        }

        public void EnviarARevision(Requisicion requisicion)
        {
            // Validaciones 
            if (requisicion.Detalles.Count == 0)
                throw new Exception("Debe agregar al menos un ítem");

            requisicion.EnviarARevision(requisicion.RemitenteID);
            _datos.EnviarARevision(requisicion.RequisicionID);
        }

        public void Aprobar(Requisicion requisicion, string comentario)
        {
            requisicion.Aprobar(requisicion.RequisicionID, comentario);
            _datos.Aprobar(requisicion.RequisicionID, (int)requisicion.AprobadorID);
        }

        public void Rechazar(Requisicion requisicion, string comentario)
        {
            requisicion.Rechazar(requisicion.RequisicionID, comentario);
            _datos.Rechazar(requisicion.RequisicionID);
        }

        public void Cancelar(Requisicion requisicion, string motivo)
        {
            requisicion.Cancelar(requisicion.RequisicionID, motivo);
            _datos.Cancelar(requisicion.RequisicionID);
        }

    }
}
