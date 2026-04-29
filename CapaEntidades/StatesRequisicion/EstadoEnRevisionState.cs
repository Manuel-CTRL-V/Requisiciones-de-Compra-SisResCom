namespace CapaEntidades.StatesRequisicion
{
    // ESTADO 2: EN REVISIÓN
    public class EstadoEnRevisionState : IEstadoRequisicion
    {
        private Requisicion _requisicion;

        public void SetRequisicion(Requisicion requisicion)
        {
            _requisicion = requisicion;
            _requisicion.EstadoID = 2; // ID del estado "En Revisión"
        }

        public void EnviarARevision(int empleadoId)
        {
            throw new Exception("La requisición ya está en revisión");
        }

        public void Aprobar(int aprobadorId, string comentario)
        {
            // TRANSICIÓN VÁLIDA: En Revisión a Aprobada
            _requisicion.CambiarEstado(new EstadoAprobadaState());
        }

        public void Rechazar(int aprobadorId, string comentario)
        {
            // TRANSICIÓN VÁLIDA: En Revisión → Rechazada
            _requisicion.CambiarEstado(new EstadoRechazadaState());
        }

        public void Cancelar(int empleadoId, string motivo)
        {
            // Permitido
            _requisicion.CambiarEstado(new EstadoCanceladaState());
        }

        public void Modificar(int empleadoId)
        {
            throw new Exception("No se puede modificar una requisición en revisión. Debe rechazarla primero.");
        }

        public void GenerarReporte()
        {
            throw new Exception("No se puede generar reporte. La requisición debe estar Aprobada.");
        }

        public bool PuedeModificar()
        {
            return false; // NO se puede modificar
        }

        public string ObtenerNombreEstado()
        {
            return "En Revisión";
        }
    }
}
