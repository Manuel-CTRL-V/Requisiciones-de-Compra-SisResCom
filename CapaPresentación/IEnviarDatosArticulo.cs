using CapaEntidades;

namespace CapaPresentación
{
    public interface IEnviarDatosArticulo
    {
        void RecibirDatosArticulo(int id, string nombre, string descripcion, string unidadMedida, decimal precioReferencia, int categoriaID, bool activo, int cantidad, PoliticaImpuesto politicaImpuesto, Proveedor proveedor);
    }
    }
