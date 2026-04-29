namespace CapaEntidades
{
    public class Articulo
    {
        public int ArticuloID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UnidadMedida { get; set; }
        public decimal PrecioReferencia { get; set; }
        public CategoriaArticulo oCategoriaArticulo { get; set; }
        public bool Activo { get; set; }
    }
}
