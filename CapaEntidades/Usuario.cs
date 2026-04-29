namespace CapaEntidades
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public Empleado oEmpleado { get; set; }
        public Rol oRol { get; set; }
        public string NombreUsuario { get; set; }
        public string PasswordHash { get; set; }
        public bool Activo { get; set; }
        public DateTime? UltimoAcceso { get; set; }
        public DateTime FechaCreacion { get; set; }

    }

}
