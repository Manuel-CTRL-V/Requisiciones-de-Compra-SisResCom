namespace CapaEntidades.StatesRequisicion
{
    // ESTADO 5: CANCELADA
    public class EstadoCanceladaState : IEstadoRequisicion
    {
        private Requisicion _requisicion;

        public void SetRequisicion(Requisicion requisicion)
        {
            _requisicion = requisicion;
            _requisicion.EstadoID = 5;
        }

        public void EnviarARevision(int empleadoId)
        {
            throw new Exception("No se puede enviar a revisión una requisición cancelada");
        }

        public void Aprobar(int aprobadorId, string comentario)
        {
            throw new Exception("No se puede aprobar una requisición cancelada");
        }

        public void Rechazar(int aprobadorId, string comentario)
        {
            throw new Exception("No se puede rechazar una requisición cancelada");
        }

        public void Cancelar(int empleadoId, string motivo)
        {
            throw new Exception("La requisición ya está cancelada");
        }

        public void Modificar(int empleadoId)
        {
            throw new Exception("No se puede modificar una requisición cancelada");
        }

        public void GenerarReporte()
        {
            throw new Exception("No se puede generar reporte de una requisición cancelada");
        }

        public bool PuedeModificar()
        {
            return false;
        }

        public string ObtenerNombreEstado()
        {
            return "Cancelada";
        }
    }
}
