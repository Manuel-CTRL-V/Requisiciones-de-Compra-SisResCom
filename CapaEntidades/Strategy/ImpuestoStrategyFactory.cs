namespace CapaEntidades.Strategy
{
    public class ImpuestoStrategyFactory
    {
        // Singleton del Factory
        private static ImpuestoStrategyFactory _instance;
        private static readonly object _lock = new object();

        private ImpuestoStrategyFactory() { }

        public static ImpuestoStrategyFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ImpuestoStrategyFactory();
                        }
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        /// Crea la estrategia basada en el ID de política de impuesto
        /// </summary>
        public ICalculoImpuestoStrategy CrearEstrategia(int politicaImpuestoId)
        {
            // Aquí podrías consultar la BD para obtener el tipo de política
            // Por simplicidad, uso un switch
            switch (politicaImpuestoId)
            {
                case 1: // ITBIS 18%
                    return new ItbisEstandarStrategy();
                case 2: // ITBIS 16%
                    return new ItbisReducidoStrategy();
                case 3: // Exento
                    return new ExentoImpuestoStrategy();
                default:
                    throw new ArgumentException($"Política de impuesto {politicaImpuestoId} no válida");
            }
        }
    }
}
