using CapaEntidades;
using CapaNegocio;
using System.Data;

namespace CapaPresentación
{
    public partial class FormNuevaRequisicion : Form, IEnviarDatosArticulo
    {
        EmpleadoServicio servicio = new EmpleadoServicio();
        List<dynamic> listaVista = new List<dynamic>();
        List<RequisicionDetalle> detalles = new List<RequisicionDetalle>();


        public int IdEmpleado { get; }

        public FormNuevaRequisicion(int idempleado)
        {
            InitializeComponent();
            IdEmpleado = idempleado;
        }

        public void RecargarDgv()
        {
            listaVista = detalles.Select(d => new
            {
                //d.DetalleID,
                //d.oRequisicionID.RequisicionID,
                NombreArticulo = d.oArticuloID.Nombre,
                NombreProveedor = d.oProveedorID.Nombre,
                d.Cantidad,
                d.PrecioUnitario,
                d.oPoliticaImpuestoID.Descripcion,
                d.Subtotal,
                d.Impuesto,
                d.Total
            }
                ).ToList<dynamic>();

            dataGridView1.DataSource = listaVista;
        }
        private void FormNuevaRequisicion_Load(object sender, EventArgs e)
        {
            CargarCmbDepartamentos();
            CargarCmbEventos();
            CargarCmbUsuarios();
            RecargarDgv();
            txtRemitente.Text = IdEmpleado.ToString();
        }
        public void RecibirDatosArticulo(int id, string nombre, string descripcion, string unidadMedida, decimal precioReferencia, int categoriaID, bool activo, int cantidad, PoliticaImpuesto politicaImpuesto, Proveedor proveedor)
        {
            Articulo articulo = new Articulo()
            {
                ArticuloID = id,
                Nombre = nombre,
                Descripcion = descripcion,
                UnidadMedida = unidadMedida,
                PrecioReferencia = precioReferencia,
                oCategoriaArticulo = new CategoriaArticulo() { CategoriaID = categoriaID, },
                Activo = activo
            };

            RequisicionDetalle requisicionDetalle = new RequisicionDetalle()
            {
                DetalleID = 0,
                oRequisicionID = new Requisicion(),
                oArticuloID = articulo,
                Cantidad = cantidad,
                oPoliticaImpuestoID = politicaImpuesto,
                PrecioUnitario = precioReferencia,
                oProveedorID = proveedor
            };

            var existente = detalles.FirstOrDefault(d => d.oArticuloID.ArticuloID == requisicionDetalle.oArticuloID.ArticuloID);

            if (existente != null)
            {
                existente.Cantidad += requisicionDetalle.Cantidad;
            }
            else
            {
                detalles.Add(requisicionDetalle);
            }

            RecargarDgv();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Requisicion requisicion = ConstruirRequisicion();
            RequisicionServicio servicio = new RequisicionServicio();
            servicio.CrearRequisicion(requisicion);
        }

        private Requisicion ConstruirRequisicion()
        {
            Requisicion requisicion = new Requisicion();
            try
            {

                int idDepartamento = Convert.ToInt32(cmbDepartamento.SelectedValue);
                int idAprobador = Convert.ToInt32(cmbAprobador.SelectedValue);
                int idRemitente = IdEmpleado;
                Evento eventoSeleccionado = (Evento)cmbEvento.SelectedItem;
                string nombreEvento = eventoSeleccionado.NombreEvento;
                int idEvento = eventoSeleccionado.EventoId;

                RequisicionBuilder builder = new RequisicionBuilder();

                builder.SetDetalles(detalles);
                builder.SetFechaCaducidad(dateTimePicker1.Value);
                builder.SetDepartamentoDestino(idDepartamento);
                builder.SetRemitente(idRemitente);

                if (cmbAprobador.Text != "No especificar") { builder.SetAprobador(idAprobador); }
                if (cmbEvento.Text != "No especificar") { builder.SetEvento(eventoSeleccionado); }
                if (!string.IsNullOrEmpty(txtObservaciones.Text)) { builder.SetObservaciones(txtObservaciones.Text); }

                requisicion = builder.Build();
               
                Limpiar();
                RecargarDgv();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inesperado:" + ex.Message, "Error");
            }
            return requisicion;
        }
        private void Limpiar()
        {
            detalles.Clear();
            txtObservaciones.Clear();
            cmbDepartamento.SelectedIndex = 0;
            cmbAprobador.SelectedIndex = 0;
            cmbEvento.SelectedIndex = 0;
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
        private void CargarCmbUsuarios()
        {
            UsuarioServicio servicio = new UsuarioServicio();
            List<Usuario> usuarios = servicio.Listar();

            var aprobadores = usuarios.Where(u => u.oRol != null && u.oRol.RolID == 1).ToList();

            aprobadores.Insert(0, new Usuario
            {
                UsuarioID = 0,
                NombreUsuario = "No especificar"
            });

            cmbAprobador.DataSource = aprobadores;
            cmbAprobador.DisplayMember = "NombreUsuario";
            cmbAprobador.ValueMember = "UsuarioID";
            cmbAprobador.SelectedIndex = 0;
        }


        private void CargarCmbEventos()
        {
            EventoServicio servicio = new EventoServicio();
            List<Evento> eventos = servicio.Listar();

            eventos.Insert(0, new Evento
            {
                EventoId = 0,
                NombreEvento = "No especificar"
            });

            cmbEvento.DataSource = eventos;
            cmbEvento.DisplayMember = "NombreEvento";
            cmbEvento.ValueMember = "EventoID";
            cmbEvento.SelectedIndex = 0;
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            FormBuscarProducto buscarProducto = new FormBuscarProducto(this);
            buscarProducto.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBorrarArticulo_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dataGridView1.SelectedRows[0];

            if (dataGridView1.SelectedRows.Count > 0)
            {

                RequisicionDetalle detalleAEliminar = detalles.Where(d => d.oArticuloID.ArticuloID == Convert.ToInt32(fila.Cells["ArticuloID"].Value)).FirstOrDefault();

                detalles.Remove(detalleAEliminar);

                btnBorrarArticulo.Enabled = false;
            }
            RecargarDgv();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            RequisicionServicio servicio = new RequisicionServicio();
            RequisicionDetalleServicio detalleServicio = new RequisicionDetalleServicio();

            Requisicion requisicion = ConstruirRequisicion();
            
            int idRequisicion = servicio.CrearRequisicion(requisicion);
            Requisicion requisicionSeleccionada = servicio.Listar().Where(r => r.RequisicionID == idRequisicion).FirstOrDefault();
            requisicionSeleccionada.Detalles = detalleServicio.ListarPorRequisicion(requisicionSeleccionada.RequisicionID);

            if (requisicionSeleccionada != null)
            {
                servicio.EnviarARevision(requisicionSeleccionada);
            }
        }
    }
}
