namespace CapaEntidades.Strategy
{
    // Estrategia 2: ITBIS 16% (ejemplo para productos específicos)
    public class ItbisReducidoStrategy : ICalculoImpuestoStrategy
    {
        private const decimal TASA_ITBIS = 0.16m;

        public decimal CalcularImpuesto(decimal subtotal)
        {
            return subtotal * TASA_ITBIS;
        }

        public string ObtenerNombrePolitica()
        {
            return "ITBIS 16%";
        }
    }
}
