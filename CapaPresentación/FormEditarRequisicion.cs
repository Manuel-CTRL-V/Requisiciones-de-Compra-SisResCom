using CapaEntidades;
using CapaNegocio;
using System.Data;

namespace CapaPresentación
{
    public partial class FormEditarRequisicion : Form, IEnviarDatosArticulo
    {
        private readonly int idEmpleado;
        List<dynamic> listaVista = new List<dynamic>();
        private int idRequisicion;

        public FormEditarRequisicion(Requisicion requisicion, List<RequisicionDetalle> detalles, int idEmpleado)
        {
            InitializeComponent();
            Requisicion = requisicion;
            Detalles = detalles;
            this.idEmpleado = idEmpleado;
        }

        public Requisicion Requisicion { get; }
        public RequisicionServicio servicio { get; }
        public List<RequisicionDetalle> Detalles { get; }

        private void FormEditarRequisicion_Load(object sender, EventArgs e)
        {
            CargarCmbDepartamentos();
            CargarCmbEventos();
            CargarCmbUsuarios();
            CargarDatosRequisicion();
            RecargarDgv();

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

            var existente = Detalles.FirstOrDefault(d => d.oArticuloID.ArticuloID == requisicionDetalle.oArticuloID.ArticuloID);

            if (existente != null)
            {
                existente.Cantidad += requisicionDetalle.Cantidad;
            }
            else
            {
                Detalles.Add(requisicionDetalle);
            }

            RecargarDgv();

        }
        public void RecargarDgv()
        {
            listaVista = Detalles.Select(d => new
            {
                //d.DetalleID,
                //d.oRequisicionID.RequisicionID,
                d.oArticuloID.ArticuloID,
                d.oProveedorID.ProveedorID,
                d.Cantidad,
                d.PrecioUnitario,
                d.oPoliticaImpuestoID.PoliticaID,
                d.Subtotal,
                d.Impuesto,
                d.Total
            }
                ).ToList<dynamic>();

            dataGridView1.DataSource = listaVista;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Requisicion.PuedeModificar())
            {
                try
                {
                    int idDepartamento = Convert.ToInt32(cmbDepartamento.SelectedValue);
                    int idAprobador = Convert.ToInt32(cmbAprobador.SelectedValue);
                    int idRemitente = idEmpleado;
                    Evento eventoSeleccionado = (Evento)cmbEvento.SelectedItem;
                    string nombreEvento = eventoSeleccionado.NombreEvento;
                    int idEvento = eventoSeleccionado.EventoId;

                    RequisicionBuilder builder = new RequisicionBuilder();
                    builder.SetDetalles(Detalles);
                    builder.SetFechaCaducidad(dateTimePicker1.Value);
                    builder.SetDepartamentoDestino(idDepartamento);
                    builder.SetRemitente(idRemitente);

                    if (cmbAprobador.Text != "No especificar") { builder.SetAprobador(idAprobador); }
                    if (cmbEvento.Text != "No especificar") { builder.SetEvento(eventoSeleccionado); }
                    if (!string.IsNullOrEmpty(txtObservaciones.Text)) { builder.SetObservaciones(txtObservaciones.Text); }

                    Requisicion requisicion = builder.Build();
                    requisicion.RequisicionID = Requisicion.RequisicionID;
                    RequisicionServicio servicio = new RequisicionServicio();
                    servicio.ActualizarRequisicion(requisicion, Detalles);
                    MessageBox.Show("Actualizado Satisfactoriamente", "Mensaje", MessageBoxButtons.OK);
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Inesperado:" + ex.Message, "Error");
                }
            }
        }

        private void CargarDatosRequisicion()
        {
            txtObservaciones.Text = Requisicion.Observaciones;
            txtRemitente.Text = Requisicion.RemitenteID.ToString();
            dateTimePicker1.Value = Requisicion.FechaCaducidad;
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnBorrarArticulo.Enabled = true;
        }

        private void btnBorrarArticulo_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dataGridView1.SelectedRows[0];

            if (dataGridView1.SelectedRows.Count > 0)
            {

                RequisicionDetalle detalleAEliminar = Detalles.Where(d => d.oArticuloID.ArticuloID == Convert.ToInt32(fila.Cells["ArticuloID"].Value)).FirstOrDefault();

                Detalles.Remove(detalleAEliminar);

                btnBorrarArticulo.Enabled = false;
            }
            RecargarDgv();
        }
    }
}
