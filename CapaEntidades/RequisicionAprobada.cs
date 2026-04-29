namespace CapaEntidades
{
    public class RequisicionAprobada
    {
        public int RequisicionID { get; set; }
        public string Referencia { get; set; }
        public string Remitente { get; set; }
        public string Aprobador { get; set; }
        public string DepartamentoDestino { get; set; }
        public string CodigoEvento { get; set; }
        public string NombreEvento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public string Observaciones { get; set; }
    }
}
