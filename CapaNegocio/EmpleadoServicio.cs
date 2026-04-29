using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class EmpleadoServicio
    {
        private readonly EmpleadoDatos datos = new();

        public List<Empleado> Listar()
        {
            return datos.Listar();
        }

        public void Guardar(Empleado empleado)
        {
            if (empleado.EmpleadoID == 0)
                datos.Insertar(empleado);
            else
                datos.Actualizar(empleado);
        }

        public void Eliminar(int empleadoID)
        {
            datos.Eliminar(empleadoID);
        }
    }
}
