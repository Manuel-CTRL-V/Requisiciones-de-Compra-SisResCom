namespace CapaEntidades.Strategy
{
    // Estrategia 1: ITBIS 18%
    public class ItbisEstandarStrategy : ICalculoImpuestoStrategy
    {
        private const decimal TASA_ITBIS = 0.18m;

        public decimal CalcularImpuesto(decimal subtotal)
        {
            return subtotal * TASA_ITBIS;
        }

        public string ObtenerNombrePolitica()
        {
            return "ITBIS 18%";
        }
    }
}
