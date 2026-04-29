namespace CapaPresentación
{
    partial class FormRegistroEmpleados
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
            components = new System.ComponentModel.Container();
            lblNombre = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbDepartamento = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cmbEstado = new ComboBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            empleadoBindingSource = new BindingSource(components);
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            btnActualizar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            label11 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(44, 26);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 76);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 129);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 181);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 3;
            label3.Text = "Telefono";
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(659, 26);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(182, 33);
            cmbDepartamento.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(526, 32);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 5;
            label4.Text = "Departamento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(568, 82);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 6;
            label5.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(659, 76);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(182, 33);
            cmbEstado.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(490, 129);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 8;
            label6.Text = "Fecha Contratacion";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DataBindings.Add(new Binding("Value", empleadoBindingSource, "FechaContratacion", true));
            dateTimePicker1.Location = new Point(659, 124);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(182, 31);
            dateTimePicker1.TabIndex = 9;
            // 
            // empleadoBindingSource
            // 
            empleadoBindingSource.DataSource = typeof(CapaEntidades.Empleado);
            // 
            // txtNombre
            // 
            txtNombre.DataBindings.Add(new Binding("Text", empleadoBindingSource, "Nombre", true));
            txtNombre.Location = new Point(146, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 31);
            txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.DataBindings.Add(new Binding("Text", empleadoBindingSource, "Apellido", true));
            txtApellido.Location = new Point(146, 76);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(245, 31);
            txtApellido.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.DataBindings.Add(new Binding("Text", empleadoBindingSource, "Email", true));
            txtEmail.Location = new Point(146, 123);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(245, 31);
            txtEmail.TabIndex = 12;
            // 
            // txtTelefono
            // 
            txtTelefono.DataBindings.Add(new Binding("Text", empleadoBindingSource, "Telefono", true));
            txtTelefono.Location = new Point(146, 175);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(245, 31);
            txtTelefono.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(44, 26);
            label7.Name = "label7";
            label7.Size = new Size(352, 45);
            label7.TabIndex = 14;
            label7.Text = "Gestion de Empleados";
            label7.TextAlign = ContentAlignment.BottomRight;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbEstado);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbDepartamento);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblNombre);
            panel1.Location = new Point(46, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 241);
            panel1.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Paintbrush;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 30;
            btnLimpiar.Location = new Point(869, 168);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(43, 38);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.TextAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(0, 167, 62);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnRegistrar.IconColor = Color.White;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrar.Location = new Point(557, 346);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(164, 59);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DeepSkyBlue;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnActualizar.IconColor = Color.White;
            btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActualizar.Location = new Point(727, 346);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(164, 59);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleLeft;
            btnActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.OrangeRed;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(897, 346);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(68, 59);
            btnEliminar.TabIndex = 18;
            btnEliminar.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 422);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(939, 324);
            dataGridView1.TabIndex = 19;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(0, 167, 62);
            label11.Location = new Point(-62, 333);
            label11.Name = "label11";
            label11.Size = new Size(1191, 10);
            label11.TabIndex = 64;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonShadow;
            label8.Location = new Point(46, 71);
            label8.Name = "label8";
            label8.Size = new Size(467, 25);
            label8.TabIndex = 20;
            label8.Text = "Registro, actualización y eliminación de empleados";
            // 
            // FormRegistroEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 811);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(panel1);
            Controls.Add(label7);
            Name = "FormRegistroEmpleados";
            Text = "FormRegistroEmpleados";
            Load += FormRegistroEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbDepartamento;
        private Label label4;
        private Label label5;
        private ComboBox cmbEstado;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private Label label7;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private BindingSource empleadoBindingSource;
        private DataGridView dataGridView1;
        private Label label11;
        private Label label8;
    }
}