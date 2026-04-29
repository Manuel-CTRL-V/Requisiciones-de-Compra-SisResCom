using CapaEntidades;
using static CapaDatos.AccesoDatos;

namespace CapaNegocio
{
    public class CategoriaServicio
        {
            private CategoriaDatos datos = new CategoriaDatos();

            public List<CategoriaArticulo> ListarCategorias()
            {
                return datos.ListarCategorias();
            }
        }
    }


