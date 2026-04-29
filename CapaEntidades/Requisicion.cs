using CapaEntidades.StatesRequisicion;

namespace CapaEntidades
{
    public class Requisicion
    {
        public int RequisicionID { get; set; }
        public string Referencia { get; set; }
        public int RemitenteID { get; set; }
        public int? AprobadorID { get; set; }
        public int DepartamentoDestinoID { get; set; }
        public Evento? oCodigoEvento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public string? Observaciones { get; set; }

        // Estado actual (FK a EstadoRequisicion)
        public int EstadoID { get; set; }

        // Patrón State: Referencia al estado actual
        private IEstadoRequisicion _estadoActual;

        public List<RequisicionDetalle> Detalles { get; set; } = new List<RequisicionDetalle>();

        // Propiedades calculadas
        public decimal Subtotal => Detalles.Sum(d => d.Subtotal);
        public decimal Impuesto => Detalles.Sum(d => d.Impuesto);
        public decimal Total => Subtotal + Impuesto;
        public Requisicion()
        {
            FechaCreacion = DateTime.Now;
            // Estado inicial
            CambiarEstado(new EstadoCreadaState());
        }
        public void SincronizarEstado()
        {
            switch (EstadoID)
            {
                case 1:
                    CambiarEstado(new EstadoCreadaState());
                    break;

                case 2:
                    CambiarEstado(new EstadoEnRevisionState());
                    break;

                case 3:
                    CambiarEstado(new EstadoAprobadaState());
                    break;

                case 4:
                    CambiarEstado(new EstadoRechazadaState());
                    break;

                case 5:
                    CambiarEstado(new EstadoCanceladaState());
                    break;

                default:
                    throw new Exception("EstadoID no válido para la requisición");
            }
        }

        /// <summary>
        /// Cambia el estado de la requisición
        /// </summary>
        public void CambiarEstado(IEstadoRequisicion nuevoEstado)
        {
            _estadoActual = nuevoEstado;
            _estadoActual.SetRequisicion(this);
        }

        // Acciones delegadas al estado
        public void EnviarARevision(int empleadoId)
        {
            _estadoActual.EnviarARevision(empleadoId);
        }

        public void Aprobar(int aprobadorId, string comentario)
        {
            _estadoActual.Aprobar(aprobadorId, comentario);
        }

        public void Rechazar(int aprobadorId, string comentario)
        {
            _estadoActual.Rechazar(aprobadorId, comentario);
        }

        public void Cancelar(int empleadoId, string motivo)
        {
            _estadoActual.Cancelar(empleadoId, motivo);
        }

        public void Modificar(int empleadoId)
        {
            _estadoActual.Modificar(empleadoId);
        }

        public void GenerarReporte()
        {
            _estadoActual.GenerarReporte();
        }

        public bool PuedeModificar()
        {
            return _estadoActual.PuedeModificar();
        }
    }
}
