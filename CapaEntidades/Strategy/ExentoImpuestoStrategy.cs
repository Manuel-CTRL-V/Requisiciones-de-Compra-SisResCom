namespace CapaEntidades.Strategy
{
    // Estrategia 3: Exento de impuestos
    public class ExentoImpuestoStrategy : ICalculoImpuestoStrategy
    {
        public decimal CalcularImpuesto(decimal subtotal)
        {
            return 0m;
        }

        public string ObtenerNombrePolitica()
        {
            return "Exento de Impuesto";
        }
    }
}
