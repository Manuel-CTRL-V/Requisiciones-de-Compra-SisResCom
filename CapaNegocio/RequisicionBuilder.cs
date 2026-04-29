using CapaEntidades;

namespace CapaNegocio
{
    public class RequisicionBuilder
    {
        private Requisicion _requisicion = new Requisicion();

        public RequisicionBuilder SetRemitente(int remitenteId)
        {
            _requisicion.RemitenteID = remitenteId;
            return this;
        }
        public RequisicionBuilder SetDetalles(List<RequisicionDetalle> detalles)
        {
            _requisicion.Detalles = new List<RequisicionDetalle>(detalles);
            return this;
        }

        public RequisicionBuilder SetAprobador(int? aprobadorId)
        {
            _requisicion.AprobadorID = aprobadorId;
            return this;
        }

        public RequisicionBuilder SetDepartamentoDestino(int departamentoId)
        {
            _requisicion.DepartamentoDestinoID = departamentoId;
            return this;
        }

        public RequisicionBuilder SetEvento(Evento evento)
        {
            _requisicion.oCodigoEvento = evento;
            return this;
        }

        public RequisicionBuilder SetFechaCaducidad(DateTime fechaCaducidad)
        {
            _requisicion.FechaCaducidad = fechaCaducidad;
            return this;
        }

        public RequisicionBuilder SetObservaciones(string observaciones)
        {
            _requisicion.Observaciones = observaciones;
            return this;
        }

        //public RequisicionBuilder AgregarItem(int articuloId, decimal cantidad,
        //                                       decimal precioUnitario, int proveedorId,
        //                                       int politicaImpuestoId)
        //{
        //    var detalle = new RequisicionDetalle
        //    {
        //        oArticuloID = new Articulo() { ArticuloID = articuloId },
        //        Cantidad = cantidad,
        //        PrecioUnitario = precioUnitario,
        //        oProveedorID = new Proveedor() { ProveedorID = proveedorId },
        //        oPoliticaImpuestoID = new PoliticaImpuesto() { PoliticaID = politicaImpuestoId }
        //    };

        //    // Validar ítem
        //    detalle.Validar();

        //    // Validar duplicados
        //    //if (_requisicion.Detalles.Any(d => d.oArticuloID.ArticuloID == articuloId))
        //    //    throw new Exception($"El artículo {articuloId} ya está agregado. No se permiten duplicados.");

        //    //_requisicion.Detalles.Add(detalle);
        //    return this;
        //}

        public Requisicion Build()
        {
            // Validaciones finales
            if (_requisicion.RemitenteID <= 0)
                throw new Exception("Debe especificar un remitente válido");

            if (_requisicion.Detalles.Count == 0)
                throw new Exception("La requisición debe contener al menos un ítem válido");

            if (_requisicion.FechaCaducidad <= DateTime.Now)
                throw new Exception("La fecha de caducidad debe ser futura");

            _requisicion.Referencia = GenerarReferencia();

            return _requisicion;
        }
        /// <summary>
        /// Generar un nombre de referencia 
        /// </summary>
        /// <returns></returns>
        private string GenerarReferencia()
        {

            return $"REQ-{DateTime.Now.Year}-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
        }
    }
}

