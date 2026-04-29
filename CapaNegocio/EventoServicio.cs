using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class EventoServicio
    {
        private readonly EventoDatos datos = new();

        public List<Evento> Listar()
        {
            return datos.Listar();
        }
    }
}
