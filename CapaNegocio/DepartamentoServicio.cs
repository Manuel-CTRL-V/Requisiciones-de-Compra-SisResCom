using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class DepartamentoServicio
    {
        private readonly DepartamentoDatos datos = new();

        public List<Departamento> Listar()
        {
            return datos.Listar();
        }
    }
}
