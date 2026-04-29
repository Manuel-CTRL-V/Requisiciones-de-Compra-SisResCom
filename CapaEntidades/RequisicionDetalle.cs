using CapaEntidades.Strategy;

namespace CapaEntidades
{
    public class RequisicionDetalle
    {
        public int DetalleID { get; set; }
        public Requisicion oRequisicionID { get; set; }
        public Articulo oArticuloID { get; set; }
        public Proveedor oProveedorID { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public PoliticaImpuesto oPoliticaImpuestoID { get; set; } // FK a PoliticaImpuesto

        // Propiedades calculadas (NO se guardan en BD directamente)
        public decimal Subtotal => Cantidad * PrecioUnitario;

        public decimal Impuesto
        {
            get
            {
                // Usa Strategy para calcular
                var factory = ImpuestoStrategyFactory.Instance;
                var strategy = factory.CrearEstrategia(oPoliticaImpuestoID.PoliticaID);
                return strategy.CalcularImpuesto(Subtotal);
            }
        }

        public decimal Total => Subtotal + Impuesto;

        // Validaciones
        public void Validar()
        {
            if (Cantidad <= 0)
                throw new Exception("La cantidad debe ser mayor a cero");

            if (PrecioUnitario <= 0)
                throw new Exception("El precio unitario debe ser mayor a cero");
        }
    }

}
