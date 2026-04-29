using CapaEntidades;
using CapaNegocio;
using FontAwesome.Sharp;

namespace CapaPresentación
{
    public partial class FormMenu : Form
    {
        /*private static Usuario usuarioActual = null;*/ // Guardar usuario actual que se está usando
        private static IconMenuItem menuActivo = null; // Para saber qué menu está activo ahora (para colorearlo)
        private static Form formActivo = null;
        private static Form formPasado = null;
        private static Usuario usuarioActual = null;
        public FormMenu(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //menu.Renderer = new CustomMenuRenderer(); // Color personalizado

            List<Permiso> permisos = new PermisoServicio().ListarPorUsuario(usuarioActual.UsuarioID);

            foreach (IconMenuItem menuItem in menu.Items)
            {
                bool encontrado = permisos.Any(m => m.NombreMenu == menuItem.Name); // Recorre la lista y devuelve falso si el nombre del menu no esta en la lista de permisos

                if (encontrado == false) menuItem.Visible = false; // Si encontrado es falso, entonces no muestra el menu
            }
        }
        private void AbrirFormulario(IconMenuItem menu, Form form)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White; // Pinta el menu activo de un color más oscuro

            }
            menu.BackColor = Color.FromArgb(0, 147, 62);
            menuActivo = menu;

            if (formActivo != null) formActivo.Close();

            // Ocultar todo lo que hay en pantalla para mostrar el form

            formActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.FromArgb(249, 250, 252);

            panel1.Controls.Add(form);
            form.Show();
        }

        private void opNuevaRequisicion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(opNuevaRequisicion, new FormNuevaRequisicion(usuarioActual.oEmpleado.EmpleadoID));
        }

        private void opRegistroEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(opRegistroEmpleados, new FormRegistroEmpleados());
        }

        private void opMisRequisiciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario(opMisRequisiciones, new FormMisRequisiciones(usuarioActual.oEmpleado.EmpleadoID));
        }

        private void opAdministrar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(opAdministrar, new FormAdmRequisiciones(usuarioActual.oEmpleado.EmpleadoID));

        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(opRequisicionesAprobadas, new FormReporte());

        }

    }
}
