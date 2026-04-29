using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class ProveedorServicio
    {
        private readonly ProveedorDatos datos = new();

        public List<Proveedor> Listar()
        {
            return datos.Listar();
        }
    }
}
