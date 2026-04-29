using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class UsuarioServicio
    {
        private readonly UsuarioDatos datos = new();

        public List<Usuario> Listar()
        {
            return datos.Listar();
        }

        public void Guardar(Usuario usuario)
        {
            if (usuario.UsuarioID == 0)
                datos.Insertar(usuario);
            else
                datos.Actualizar(usuario);
        }

        public Usuario ObtenerPorUsuario(string nombreUsuario)
        {
            return datos.ObtenerPorUsuario(nombreUsuario);
        }
        public void ActualizarAcceso(int usuarioID)
        {
            datos.ActualizarAcceso(usuarioID);
        }

    }
}

