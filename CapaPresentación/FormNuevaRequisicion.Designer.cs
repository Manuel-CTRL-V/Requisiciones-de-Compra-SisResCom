namespace CapaPresentación
{
    partial class FormNuevaRequisicion
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
            cmbAprobador = new ComboBox();
            cmbEvento = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtObservaciones = new TextBox();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnEnviar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cmbDepartamento = new ComboBox();
            dataGridView1 = new DataGridView();
            btnAgregarArticulo = new FontAwesome.Sharp.IconButton();
            btnBorrarArticulo = new FontAwesome.Sharp.IconButton();
            txtRemitente = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label10 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label12 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbAprobador
            // 
            cmbAprobador.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAprobador.FormattingEnabled = true;
            cmbAprobador.Items.AddRange(new object[] { "No especificar" });
            cmbAprobador.Location = new Point(152, 79);
            cmbAprobador.Name = "cmbAprobador";
            cmbAprobador.Size = new Size(245, 33);
            cmbAprobador.TabIndex = 12;
            // 
            // cmbEvento
            // 
            cmbEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEvento.FormattingEnabled = true;
            cmbEvento.Items.AddRange(new object[] { "No especificar" });
            cmbEvento.Location = new Point(589, 139);
            cmbEvento.Name = "cmbEvento";
            cmbEvento.Size = new Size(245, 33);
            cmbEvento.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(152, 203);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(245, 31);
            dateTimePicker1.TabIndex = 17;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(589, 206);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(417, 88);
            txtObservaciones.TabIndex = 18;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSize = true;
            btnGuardar.BackColor = Color.FromArgb(0, 167, 62);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 28;
            btnGuardar.Location = new Point(776, 313);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(115, 42);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.AutoSize = true;
            btnEnviar.FlatAppearance.BorderColor = Color.Black;
            btnEnviar.FlatAppearance.BorderSize = 2;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviar.ForeColor = Color.FromArgb(0, 167, 62);
            btnEnviar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEnviar.IconColor = Color.Black;
            btnEnviar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEnviar.IconSize = 28;
            btnEnviar.Location = new Point(894, 313);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(112, 42);
            btnEnviar.TabIndex = 21;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 82);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 23;
            label2.Text = "Aprobador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 82);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 24;
            label3.Text = "Departamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(517, 142);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 25;
            label4.Text = "Evento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 209);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 27;
            label6.Text = "Fecha Límite";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 144);
            label7.Name = "label7";
            label7.Size = new Size(137, 25);
            label7.TabIndex = 28;
            label7.Text = "Id de Remitente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(456, 204);
            label8.Name = "label8";
            label8.Size = new Size(128, 25);
            label8.TabIndex = 29;
            label8.Text = "Observaciones";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(27, 0);
            label9.Name = "label9";
            label9.Size = new Size(229, 32);
            label9.TabIndex = 30;
            label9.Text = "Nueva Requisición";
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(589, 74);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(245, 33);
            cmbDepartamento.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 507);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(958, 230);
            dataGridView1.TabIndex = 32;
            // 
            // btnAgregarArticulo
            // 
            btnAgregarArticulo.AutoSize = true;
            btnAgregarArticulo.BackColor = Color.FromArgb(0, 167, 62);
            btnAgregarArticulo.FlatAppearance.BorderSize = 0;
            btnAgregarArticulo.FlatStyle = FlatStyle.Flat;
            btnAgregarArticulo.ForeColor = Color.White;
            btnAgregarArticulo.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAgregarArticulo.IconColor = Color.White;
            btnAgregarArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarArticulo.IconSize = 28;
            btnAgregarArticulo.Location = new Point(838, 455);
            btnAgregarArticulo.Name = "btnAgregarArticulo";
            btnAgregarArticulo.Size = new Size(180, 35);
            btnAgregarArticulo.TabIndex = 33;
            btnAgregarArticulo.Text = "Agregar Articulo";
            btnAgregarArticulo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarArticulo.UseVisualStyleBackColor = false;
            btnAgregarArticulo.Click += btnAgregarArticulo_Click;
            // 
            // btnBorrarArticulo
            // 
            btnBorrarArticulo.AutoSize = true;
            btnBorrarArticulo.BackColor = Color.OrangeRed;
            btnBorrarArticulo.FlatAppearance.BorderSize = 0;
            btnBorrarArticulo.FlatStyle = FlatStyle.Flat;
            btnBorrarArticulo.ForeColor = Color.White;
            btnBorrarArticulo.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnBorrarArticulo.IconColor = Color.White;
            btnBorrarArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrarArticulo.IconSize = 28;
            btnBorrarArticulo.Location = new Point(656, 455);
            btnBorrarArticulo.Name = "btnBorrarArticulo";
            btnBorrarArticulo.Size = new Size(176, 35);
            btnBorrarArticulo.TabIndex = 34;
            btnBorrarArticulo.Text = "Borrar Articulo";
            btnBorrarArticulo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrarArticulo.UseVisualStyleBackColor = false;
            btnBorrarArticulo.Click += btnBorrarArticulo_Click;
            // 
            // txtRemitente
            // 
            txtRemitente.Enabled = false;
            txtRemitente.Location = new Point(152, 141);
            txtRemitente.Name = "txtRemitente";
            txtRemitente.Size = new Size(245, 31);
            txtRemitente.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(840, 73);
            label1.Name = "label1";
            label1.Size = new Size(22, 30);
            label1.TabIndex = 36;
            label1.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(403, 205);
            label5.Name = "label5";
            label5.Size = new Size(22, 30);
            label5.TabIndex = 37;
            label5.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(403, 142);
            label10.Name = "label10";
            label10.Size = new Size(22, 30);
            label10.TabIndex = 38;
            label10.Text = "*";
            // 
            // iconButton1
            // 
            iconButton1.AutoSize = true;
            iconButton1.BackColor = Color.FromArgb(0, 167, 62);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 28;
            iconButton1.Location = new Point(898, 68);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(108, 35);
            iconButton1.TabIndex = 39;
            iconButton1.Text = "Limpiar";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtRemitente);
            panel1.Controls.Add(cmbDepartamento);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnEnviar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtObservaciones);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(cmbEvento);
            panel1.Controls.Add(cmbAprobador);
            panel1.Location = new Point(17, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1023, 402);
            panel1.TabIndex = 40;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonShadow;
            label12.Location = new Point(27, 32);
            label12.Name = "label12";
            label12.Size = new Size(466, 25);
            label12.TabIndex = 40;
            label12.Text = "Crear una requisición, como borrador o para enviar";
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(0, 167, 62);
            label11.Location = new Point(-21, 426);
            label11.Name = "label11";
            label11.Size = new Size(1191, 10);
            label11.TabIndex = 64;
            // 
            // FormNuevaRequisicion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 768);
            Controls.Add(label11);
            Controls.Add(panel1);
            Controls.Add(btnBorrarArticulo);
            Controls.Add(btnAgregarArticulo);
            Controls.Add(dataGridView1);
            Name = "FormNuevaRequisicion";
            Text = "FormNuevaRequisicion";
            Load += FormNuevaRequisicion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbAprobador;
        private ComboBox cmbEvento;
        private DateTimePicker dateTimePicker1;
        private TextBox txtObservaciones;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEnviar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cmbDepartamento;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnAgregarArticulo;
        private FontAwesome.Sharp.IconButton btnBorrarArticulo;
        private TextBox txtRemitente;
        private Label label1;
        private Label label5;
        private Label label10;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
        private Label label11;
        private Label label12;
    }
}