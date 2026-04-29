namespace CapaEntidades.StatesRequisicion
{
    /// <summary>
    /// Contrato para los estados de una requisición
    /// </summary>
    public interface IEstadoRequisicion
    {
        void SetRequisicion(Requisicion requisicion);
        void EnviarARevision(int empleadoId);
        void Aprobar(int aprobadorId, string comentario);
        void Rechazar(int aprobadorId, string comentario);
        void Cancelar(int empleadoId, string motivo);
        void Modificar(int empleadoId);
        void GenerarReporte();
        bool PuedeModificar();
        string ObtenerNombreEstado();
    }
}
