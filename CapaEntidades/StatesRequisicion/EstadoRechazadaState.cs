namespace CapaEntidades.StatesRequisicion
{
    // ESTADO 4: RECHAZADA
    public class EstadoRechazadaState : IEstadoRequisicion
    {
        private Requisicion _requisicion;

        public void SetRequisicion(Requisicion requisicion)
        {
            _requisicion = requisicion;
            _requisicion.EstadoID = 4;
        }

        public void EnviarARevision(int empleadoId)
        {
            throw new Exception("No se puede reenviar una requisición rechazada");
        }

        public void Aprobar(int aprobadorId, string comentario)
        {
            throw new Exception("No se puede aprobar una requisición rechazada");
        }

        public void Rechazar(int aprobadorId, string comentario)
        {
            throw new Exception("La requisición ya está rechazada");
        }

        public void Cancelar(int empleadoId, string motivo)
        {
            throw new Exception("No se puede cancelar una requisición rechazada");
        }

        public void Modificar(int empleadoId)
        {
            throw new Exception("No se puede modificar una requisición rechazada");
        }

        public void GenerarReporte()
        {
            throw new Exception("No se puede generar reporte de una requisición rechazada");
        }

        public bool PuedeModificar()
        {
            return false;
        }

        public string ObtenerNombreEstado()
        {
            return "Rechazada";
        }
    }
}
