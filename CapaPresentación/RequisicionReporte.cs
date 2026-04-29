namespace CapaPresentación
{
    public class RequisicionReporte
        {
            public int RequisicionID { get; set; }
            public string Referencia { get; set; }
            public string Remitente { get; set; }
            public string Aprobador { get; set; }
            public string DepartamentoDestino { get; set; }
            public string CodigoEvento { get; set; }
            public string NombreEvento { get; set; }
            public string FechaCreacion { get; set; }
            public string FechaCaducidad { get; set; }
            public string Observaciones { get; set; }
        }
    }
