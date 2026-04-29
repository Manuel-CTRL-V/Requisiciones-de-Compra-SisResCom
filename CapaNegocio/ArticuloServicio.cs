using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class ArticuloServicio
    {
        private readonly ArticuloDatos datos = new();

        public List<Articulo> Listar()
        {
            return datos.Listar();
        }
    }
}


