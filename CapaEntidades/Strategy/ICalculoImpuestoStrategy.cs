namespace CapaEntidades.Strategy
{
    /// <summary>
    /// Contrato para las estrategias de cálculo de impuestos
    /// </summary>
    public interface ICalculoImpuestoStrategy
    {
        decimal CalcularImpuesto(decimal subtotal);
        string ObtenerNombrePolitica();
    }
}
