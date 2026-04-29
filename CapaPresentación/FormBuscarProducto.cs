using CapaEntidades;
using CapaNegocio;
using System.Data;

namespace CapaPresentación
{
    public partial class FormBuscarProducto : Form
    {
        public List<dynamic> listaVista;
        public IEnviarDatosArticulo enviarDatosArticulo1 { get; }
        public FormBuscarProducto(IEnviarDatosArticulo enviarDatosArticulo)
        {
            InitializeComponent();
            enviarDatosArticulo1 = enviarDatosArticulo;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                int id = Convert.ToInt32(filaSeleccionada.Cells["ArticuloID"].Value);
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string descripcion = filaSeleccionada.Cells["Descripcion"].Value.ToString();
                string unidadMedida = filaSeleccionada.Cells["UnidadMedida"].Value.ToString();
                decimal precioReferencia = Convert.ToDecimal(filaSeleccionada.Cells["PrecioReferencia"].Value);
                bool activo = Convert.ToBoolean(filaSeleccionada.Cells["Activo"].Value);
                int categoriaID = Convert.ToInt32(filaSeleccionada.Cells["CategoriaID"].Value);
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                DialogResult result = MessageBox.Show("¿Quiere seleccionar este articulo para la Requisición?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    enviarDatosArticulo1.RecibirDatosArticulo(id, nombre, descripcion, unidadMedida, precioReferencia, categoriaID, activo, cantidad, (PoliticaImpuesto)cmbPoliticaImpuesto.SelectedItem, (Proveedor)cmbProveedor.SelectedItem);
                    this.Close();
                }
            }
        }


        private void CargarCmbProveedores()
        {
            ProveedorServicio servicio = new ProveedorServicio();
            List<Proveedor> Proveedors = servicio.Listar();

            cmbProveedor.DataSource = Proveedors;
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "ProveedorID";
            //cmbProveedor.SelectedIndex = 0;
        }
        private void CargarCmbPoliticaImpuestos()
        {
            PoliticaImpuestoServicio servicio = new PoliticaImpuestoServicio();
            List<PoliticaImpuesto> PoliticaImpuestos = servicio.Listar();

            cmbPoliticaImpuesto.DataSource = PoliticaImpuestos;
            cmbPoliticaImpuesto.DisplayMember = "Nombre";
            cmbPoliticaImpuesto.ValueMember = "PoliticaID";
            //cmbPoliticaImpuesto.SelectedIndex = 0;
        }
        public void CargarDgv()
        {
            ArticuloServicio servicio = new ArticuloServicio();
            var listaServicios = servicio.Listar();
            listaVista = listaServicios.Select(m => new
            {
                m.ArticuloID,
                m.Nombre,
                m.Descripcion,
                m.UnidadMedida,
                m.PrecioReferencia,
                m.oCategoriaArticulo.CategoriaID,
                m.Activo
            }
            ).ToList<dynamic>();

            dataGridView1.DataSource = listaVista;
        }
        public static void CargarFiltro(DataGridView dgv, ComboBox cmb_Filtro)
        {
            foreach (DataGridViewColumn columna in dgv.Columns)
            {
                if (columna.Visible)
                {
                    cmb_Filtro.Items.Add(columna.HeaderText);
                }
                cmb_Filtro.SelectedIndex = 0;
            }
        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            CargarCmbPoliticaImpuestos();
            CargarCmbProveedores();
            CargarDgv();
            CargarFiltro(dataGridView1, cmbFiltro);

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string columna = cmbFiltro.SelectedItem.ToString();
            string texto = txtFiltro.Text.ToLower();
            ArticuloServicio servicio = new ArticuloServicio();
            var listaArticulos = servicio.Listar();
            
            // EXPRESIONES LAMBDA: si encuentra en la lista de clientes, un cliente que coincide con lo que se busca, lo manda como datasource al datagridview
            // TYPEOF

            listaArticulos= listaArticulos.Where(u => typeof(Articulo).GetProperty(columna).GetValue(u, null)?.ToString().ToLower().Contains(texto) == true).ToList();
            listaVista = listaArticulos.Select(m => new
            {
                m.ArticuloID,
                m.Nombre,
                m.Descripcion,
                m.UnidadMedida,
                m.PrecioReferencia,
                m.oCategoriaArticulo.CategoriaID,
                m.Activo
            }
            ).ToList<dynamic>();
            dataGridView1.DataSource = listaVista;
        }
    }
}
