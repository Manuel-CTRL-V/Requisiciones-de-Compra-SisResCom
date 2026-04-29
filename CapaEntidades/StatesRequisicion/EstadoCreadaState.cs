
namespace CapaEntidades.StatesRequisicion
{
    // ESTADO 1: CREADA
    public class EstadoCreadaState : IEstadoRequisicion
    {
        private Requisicion _requisicion;

        public void SetRequisicion(Requisicion requisicion)
        {
            _requisicion = requisicion;
            _requisicion.EstadoID = 1; // ID del estado "Creada" en BD
        }

        public void EnviarARevision(int empleadoId)
        {
            // Validar que tenga al menos 1 ítem
            if (_requisicion.Detalles.Count == 0)
                throw new Exception("No se puede enviar a revisión sin ítems");

            // Cambiar al estado "En Revisión"
            _requisicion.CambiarEstado(new EstadoEnRevisionState());

        }

        public void Aprobar(int aprobadorId, string comentario)
        {
            throw new Exception("No se puede aprobar una requisición en estado Creada. Debe estar En Revisión.");
        }

        public void Rechazar(int aprobadorId, string comentario)
        {
            throw new Exception("No se puede rechazar una requisición en estado Creada.");
        }

        public void Cancelar(int empleadoId, string motivo)
        {
            // Permitido: cambiar a estado Cancelada
            _requisicion.CambiarEstado(new EstadoCanceladaState());
            // Guardar historial
        }

        public void Modificar(int empleadoId)
        {
            // Permitido: está en estado editable
            // Lógica de modificación
        }

        public void GenerarReporte()
        {
            throw new Exception("No se puede generar reporte. La requisición debe estar Aprobada.");
        }

        public bool PuedeModificar()
        {
            return true; // SÍ se puede modificar
        }

        public string ObtenerNombreEstado()
        {
            return "Creada";
        }
    }
}
