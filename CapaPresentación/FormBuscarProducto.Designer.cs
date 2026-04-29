namespace CapaPresentación
{
    partial class FormBuscarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            cmbProveedor = new ComboBox();
            cmbPoliticaImpuesto = new ComboBox();
            txtCantidad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            cmbFiltro = new ComboBox();
            txtFiltro = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 57);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(931, 354);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(134, 9);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(182, 33);
            cmbProveedor.TabIndex = 1;
            // 
            // cmbPoliticaImpuesto
            // 
            cmbPoliticaImpuesto.FormattingEnabled = true;
            cmbPoliticaImpuesto.Location = new Point(432, 9);
            cmbPoliticaImpuesto.Name = "cmbPoliticaImpuesto";
            cmbPoliticaImpuesto.Size = new Size(182, 33);
            cmbPoliticaImpuesto.TabIndex = 2;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(739, 9);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(209, 31);
            txtCantidad.TabIndex = 3;
            txtCantidad.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 4;
            label1.Text = "Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 12);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 5;
            label2.Text = "Impuesto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(645, 12);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 6;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 414);
            label4.Name = "label4";
            label4.Size = new Size(192, 25);
            label4.TabIndex = 7;
            label4.Text = "(Seleccione un articulo)";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(cmbPoliticaImpuesto);
            panel1.Controls.Add(cmbProveedor);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(42, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 452);
            panel1.TabIndex = 8;
            // 
            // cmbFiltro
            // 
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Location = new Point(176, 43);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(182, 33);
            cmbFiltro.TabIndex = 9;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(380, 45);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(276, 31);
            txtFiltro.TabIndex = 10;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 46);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 11;
            label5.Text = "Buscar por:";
            // 
            // FormBuscarProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 252);
            ClientSize = new Size(1081, 557);
            Controls.Add(label5);
            Controls.Add(txtFiltro);
            Controls.Add(cmbFiltro);
            Controls.Add(panel1);
            Name = "FormBuscarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuscarProducto";
            Load += BuscarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbProveedor;
        private ComboBox cmbPoliticaImpuesto;
        private TextBox txtCantidad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private ComboBox cmbFiltro;
        private TextBox txtFiltro;
        private Label label5;
    }
}