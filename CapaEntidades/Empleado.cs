namespace CapaEntidades
{
    public class Empleado
    {
        public int EmpleadoID { get; set; }
        public Departamento oDepartamento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaContratacion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public string NombreCompleto =>
            $"{Nombre} {Apellido}";
    }

}
