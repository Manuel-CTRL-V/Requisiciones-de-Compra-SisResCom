using CapaEntidades;
using CapaNegocio;
using System.Data;

namespace CapaPresentación
{
    public partial class FormMisRequisiciones : Form
    {
        private readonly int idEmpleado;
        public int idRequisicion;
        List<dynamic> vistaBorradores = new List<dynamic>();
        List<dynamic> vistaEnviados = new List<dynamic>();
        RequisicionServicio servicio = new RequisicionServicio();
        RequisicionDetalleServicio detalleServicio = new RequisicionDetalleServicio();

        public FormMisRequisiciones(int idEmpleado)
        {
            InitializeComponent();
            this.idEmpleado = idEmpleado;
        }

        private void FormMisRequisiciones_Load(object sender, EventArgs e)
        {
            CargarBorradores();
            CargarEnviados();
        }
        private void CargarBorradores()
        {
            List<Requisicion> requisiciones = servicio.Listar().Where(r => r.RemitenteID == idEmpleado && (r.EstadoID == 1 || r.EstadoID == 5)).ToList();
            vistaBorradores = requisiciones.Select(r => new
            {
                r.RequisicionID,
                CodigoReferencia = r.Referencia,
                ÀprobadorID = r.AprobadorID == null ? "No especificado" : r.AprobadorID.ToString(),
                r.EstadoID,
            }).ToList<dynamic>();

            dgvBorradores.DataSource = vistaBorradores;
        }


        private void CargarEnviados()
        {
            List<Requisicion> requisiciones = servicio.Listar().Where(r => r.RemitenteID == idEmpleado && r.EstadoID == 2).ToList();
            vistaEnviados = requisiciones.Select(r => new
            {
                r.Referencia,
                ÀprobadorID = r.AprobadorID == null ? "No especificado" : r.AprobadorID.ToString(),
                r.EstadoID,
            }).ToList<dynamic>();

            dgvEnviadas.DataSource = vistaEnviados;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Requisicion requisicionSeleccionada = servicio.Listar().Where(r => r.RequisicionID == idRequisicion).FirstOrDefault();
            string estadoActual = requisicionSeleccionada.EstadoID.ToString();
            requisicionSeleccionada.Detalles = detalleServicio.ListarPorRequisicion(requisicionSeleccionada.RequisicionID);

            if (requisicionSeleccionada != null)
            {
                servicio.Cancelar(requisicionSeleccionada, "");
            }
            CargarBorradores();
        }

        private void dgvBorradores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBorradores.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvBorradores.SelectedRows[0];

                idRequisicion = Convert.ToInt32(fila.Cells["RequisicionID"].Value);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Requisicion requisicionSeleccionada = servicio.Listar().Where(r => r.RequisicionID == idRequisicion).FirstOrDefault();
            requisicionSeleccionada.Detalles = detalleServicio.ListarPorRequisicion(requisicionSeleccionada.RequisicionID);

            if (requisicionSeleccionada != null)
            {
                servicio.EnviarARevision(requisicionSeleccionada);
            }
            CargarBorradores();
            CargarEnviados();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Requisicion requisicionSeleccionada = servicio.Listar().Where(r => r.RequisicionID == idRequisicion).FirstOrDefault();
            List<RequisicionDetalle> detalles = requisicionSeleccionada.Detalles = detalleServicio.ListarPorRequisicion(requisicionSeleccionada.RequisicionID);


            var formEditarRequisicion = new FormEditarRequisicion(requisicionSeleccionada, detalles, idEmpleado);
            formEditarRequisicion.ShowDialog();
        }
    }
}
