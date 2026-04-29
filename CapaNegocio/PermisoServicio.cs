using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class PermisoServicio
    {
        private readonly PermisoDatos datos = new();

        public List<Permiso> ListarPorUsuario(int usuarioID)
        {
            return datos.ListarPorUsuario(usuarioID);
        }
    }
}
