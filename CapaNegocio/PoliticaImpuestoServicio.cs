using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class PoliticaImpuestoServicio
    {

        private readonly PoliticaImpuestoDatos datos = new();

        public List<PoliticaImpuesto> Listar()
        {
            return datos.Listar();
        }
    }
}
