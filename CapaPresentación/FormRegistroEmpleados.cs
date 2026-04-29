using CapaEntidades;
using CapaNegocio;

namespace CapaPresentación
{
    public partial class FormRegistroEmpleados : Form
    {
        EmpleadoServicio _servicio = new EmpleadoServicio();
        public FormRegistroEmpleados()
        {
            InitializeComponent();
        }
        private void FormRegistroEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarCmbDepartamentos();
            Limpiar();
            if (empleadoBindingSource.Current == null)
            {
                empleadoBindingSource.Add(new Empleado());
            }
        }

        private void Limpiar()
        {
            this.Controls.OfType<System.Windows.Forms.TextBox>().ToList()
                .ForEach(t => t.Clear());

            cmbDepartamento.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void CargarCmbDepartamentos()
        {
            DepartamentoServicio servicio = new DepartamentoServicio();
            List<Departamento> departamentos = servicio.Listar();

            cmbDepartamento.DataSource = departamentos;
            cmbDepartamento.DisplayMember = "Nombre";
            cmbDepartamento.ValueMember = "DepartamentoID";
            cmbDepartamento.SelectedIndex = 0;

        }

        private void CargarEmpleados()
        {
            List<dynamic> listaVista = new List<dynamic>();
            listaVista = _servicio.Listar().Select(e => new
            {
                e.EmpleadoID,
                e.NombreCompleto,
                e.oDepartamento.DepartamentoID,
                e.Telefono,
                e.Email,
                e.Activo
            }).ToList<dynamic>();


            dataGridView1.DataSource = listaVista;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                empleadoBindingSource.EndEdit();

                Empleado empleado = (Empleado)empleadoBindingSource.Current;
                empleado.oDepartamento = (Departamento)cmbDepartamento.SelectedItem;
                empleado.Activo = cmbEstado.Text == "Activo" ? true : false;


                if (string.IsNullOrWhiteSpace(empleado.Nombre))
                {
                    MessageBox.Show("Debe ingresar el nombre del empleado");
                    return;
                }

                if (string.IsNullOrWhiteSpace(empleado.Apellido))
                {
                    MessageBox.Show("Debe ingresar el apellido del empelado");
                    return;
                }
                if (string.IsNullOrWhiteSpace(empleado.Telefono))
                {
                    MessageBox.Show("Debe ingresar el telefono del empleado");
                    return;
                }

                if (string.IsNullOrWhiteSpace(empleado.Email))
                {
                    MessageBox.Show("Debe ingresar el email del empelado");
                    return;
                }
                if (empleado.FechaContratacion > DateTime.Now)
                {
                    MessageBox.Show("Debe ingresar una fecha válida");
                    return;
                }

                var servicio = new EmpleadoServicio();

                servicio.Guardar(empleado);
                MessageBox.Show("Producto registrado correctamente", "Mensaje", MessageBoxButtons.OK);
                empleadoBindingSource.ResetCurrentItem();
                Limpiar();


            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR: " + ex.Message, "ERROR INESPERADO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                CargarEmpleados();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
