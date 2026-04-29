namespace CapaEntidades.StatesRequisicion
{
    // ESTADO 3: APROBADA
    public class EstadoAprobadaState : IEstadoRequisicion
    {
        private Requisicion _requisicion;

        public void SetRequisicion(Requisicion requisicion)
        {
            _requisicion = requisicion;
            _requisicion.EstadoID = 3;
        }

        public void EnviarARevision(int empleadoId)
        {
            throw new Exception("No se puede enviar a revisión una requisición aprobada");
        }

        public void Aprobar(int aprobadorId, string comentario)
        {
            throw new Exception("La requisición ya está aprobada");
        }

        public void Rechazar(int aprobadorId, string comentario)
        {
            throw new Exception("No se puede rechazar una requisición ya aprobada");
        }

        public void Cancelar(int empleadoId, string motivo)
        {
            throw new Exception("No se puede cancelar una requisición aprobada");
        }

        public void Modificar(int empleadoId)
        {
            throw new Exception("No se puede modificar una requisición aprobada");
        }

        public void GenerarReporte()
        {
            // Falta 
        }

        public bool PuedeModificar()
        {
            return false; // BLOQUEADO
        }

        public string ObtenerNombreEstado()
        {
            return "Aprobada";
        }
    }
}
