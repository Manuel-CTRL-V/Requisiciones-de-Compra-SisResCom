using CapaEntidades;
using CapaNegocio;
using System.Data;

namespace CapaPresentación
{
    public partial class FormAdmRequisiciones : Form
    {
        List<dynamic> vistaBorradores = new List<dynamic>();
        List<dynamic> vista = new List<dynamic>();
        Requisicion requisicionSeleccionada;
        RequisicionServicio servicio = new RequisicionServicio();
        RequisicionDetalleServicio servicioDetalle = new RequisicionDetalleServicio();
        private int idRequisicion;
        private readonly int idEmpleado;

        public FormAdmRequisiciones(int idEmpleado)
        {
            InitializeComponent();
            this.idEmpleado = idEmpleado;
        }

        private void FormAdmRequisiciones_Load(object sender, EventArgs e)
        {
            CargarCmbDepartamentos();
            CargarCmbEventos();
            cmbVista.SelectedIndex = 0;

            CargarEnviadosParaMi();
            //}
            //else if (cmbVista.Text == "General")
            //{
            //    CargarEnviados();
            //}
        }
        private void Limpiar()
        {
            txtComentarios.Clear();
            txtObservaciones.Clear();
            txtRemitente.Clear();
            CargarEnviadosParaMi();
            CargarEnviados();
            CargarCmbDepartamentos();
            CargarCmbEventos();
            cmbVista.SelectedIndex = 0;
            dataGridView2.DataSource = vista;
        }

        private void CargarEnviadosParaMi()
        {
            List<Requisicion> requisiciones = servicio.Listar().Where(r => r.AprobadorID == idEmpleado && r.EstadoID == 2).ToList();

            foreach (Requisicion re in requisiciones)
            {
                re.SincronizarEstado();
            }

            vista = requisiciones.Select(r => new
            {
                r.RequisicionID,
                r.Referencia,
                r.RemitenteID,
                r.EstadoID
            }).ToList<dynamic>();

            dataGridView1.DataSource = vista;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name == "RequisicionID")
                {
                    column.Visible = false;
                }
                ;
            }
        }
        private void CargarEnviados()
        {
            List<Requisicion> requisiciones = servicio.Listar().Where(r => r.EstadoID == 2).ToList();
            vista = requisiciones.Select(r => new
            {
                r.RequisicionID,
                r.FechaCaducidad,
                r.Referencia,
                r.RemitenteID,
                r.EstadoID
            }).ToList<dynamic>();

            dataGridView1.DataSource = vista;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name == "RequisicionID")
                {
                    column.Visible = false;
                }
                ;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];

                idRequisicion = Convert.ToInt32(fila.Cells["RequisicionID"].Value);


                requisicionSeleccionada = servicio.Listar().Where(r => r.RequisicionID == idRequisicion).FirstOrDefault();

                if (requisicionSeleccionada != null)
                {
                    txtRemitente.Text = requisicionSeleccionada.RemitenteID.ToString();
                    txtObservaciones.Text = requisicionSeleccionada.Observaciones;
                    dateTimePicker1.Value = requisicionSeleccionada.FechaCaducidad;
                    List<RequisicionDetalle> listaDgvArticulos = servicioDetalle.ListarPorRequisicion(requisicionSeleccionada.RequisicionID);

                    List<dynamic> listaVista = listaDgvArticulos.Select(r => new
                    {
                        r.DetalleID,
                        r.oRequisicionID.RequisicionID,
                        r.oArticuloID.ArticuloID,
                        r.Cantidad,
                        Impuesto = r.oPoliticaImpuestoID.PoliticaID,
                        r.oProveedorID.ProveedorID,
                        r.PrecioUnitario,
                        r.Subtotal,
                        r.Total,
                    }).ToList<dynamic>();

                    dataGridView2.DataSource = listaVista;

                    cmbDepartamento.SelectedIndex = requisicionSeleccionada.DepartamentoDestinoID - 1;
                    cmbEvento.SelectedIndex = requisicionSeleccionada.oCodigoEvento == null ? 0 : requisicionSeleccionada.oCodigoEvento.EventoId - 1;
                }
            }
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

        private void CargarCmbEventos()
        {
            EventoServicio servicio = new EventoServicio();
            List<Evento> Eventos = servicio.Listar();

            cmbEvento.DataSource = Eventos;
            cmbEvento.DisplayMember = "NombreEvento";
            cmbEvento.ValueMember = "EventoID";
            cmbEvento.SelectedIndex = 0;
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            requisicionSeleccionada.AprobadorID = idEmpleado;
            requisicionSeleccionada.SincronizarEstado();
            servicio.Aprobar(requisicionSeleccionada, txtComentarios.Text);
            MessageBox.Show("Aprobada correctamente");
            Limpiar();
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            requisicionSeleccionada.SincronizarEstado();
            servicio.Rechazar(requisicionSeleccionada, txtComentarios.Text);
            MessageBox.Show("Rechazada correctamente");
            Limpiar();
        }

        private void btnEnviarARevision_Click(object sender, EventArgs e)
        {
            requisicionSeleccionada.SincronizarEstado();
            servicio.Cancelar(requisicionSeleccionada, txtComentarios.Text);
            MessageBox.Show("Cancelada correctamente");
            Limpiar();
        }

        private void cmbVista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVista.Text == "Para mí")
            {
                CargarEnviadosParaMi();
            }
            else if (cmbVista.Text == "General")
            {
                CargarEnviados();
            }
        }
    }
}
