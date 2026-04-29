namespace CapaPresentación
{
    partial class FormEditarRequisicion
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            label5 = new Label();
            label1 = new Label();
            txtRemitente = new TextBox();
            btnBorrarArticulo = new FontAwesome.Sharp.IconButton();
            btnAgregarArticulo = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            cmbDepartamento = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtObservaciones = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cmbEvento = new ComboBox();
            cmbAprobador = new ComboBox();
            panel1 = new Panel();
            label12 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(0, 167, 62);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(919, 72);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(85, 34);
            iconButton1.TabIndex = 61;
            iconButton1.Text = "Limpiar";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(401, 145);
            label10.Name = "label10";
            label10.Size = new Size(22, 30);
            label10.TabIndex = 60;
            label10.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(401, 208);
            label5.Name = "label5";
            label5.Size = new Size(22, 30);
            label5.TabIndex = 59;
            label5.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(838, 76);
            label1.Name = "label1";
            label1.Size = new Size(22, 30);
            label1.TabIndex = 58;
            label1.Text = "*";
            // 
            // txtRemitente
            // 
            txtRemitente.Enabled = false;
            txtRemitente.Location = new Point(150, 144);
            txtRemitente.Name = "txtRemitente";
            txtRemitente.Size = new Size(245, 31);
            txtRemitente.TabIndex = 57;
            // 
            // btnBorrarArticulo
            // 
            btnBorrarArticulo.AutoSize = true;
            btnBorrarArticulo.BackColor = Color.OrangeRed;
            btnBorrarArticulo.Enabled = false;
            btnBorrarArticulo.FlatAppearance.BorderSize = 0;
            btnBorrarArticulo.FlatStyle = FlatStyle.Flat;
            btnBorrarArticulo.ForeColor = Color.White;
            btnBorrarArticulo.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnBorrarArticulo.IconColor = Color.White;
            btnBorrarArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrarArticulo.IconSize = 28;
            btnBorrarArticulo.Location = new Point(658, 475);
            btnBorrarArticulo.Name = "btnBorrarArticulo";
            btnBorrarArticulo.Size = new Size(176, 35);
            btnBorrarArticulo.TabIndex = 56;
            btnBorrarArticulo.Text = "Borrar Articulo";
            btnBorrarArticulo.TextAlign = ContentAlignment.MiddleLeft;
            btnBorrarArticulo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrarArticulo.UseVisualStyleBackColor = false;
            btnBorrarArticulo.Click += btnBorrarArticulo_Click;
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
            btnAgregarArticulo.Location = new Point(840, 475);
            btnAgregarArticulo.Name = "btnAgregarArticulo";
            btnAgregarArticulo.Size = new Size(180, 35);
            btnAgregarArticulo.TabIndex = 55;
            btnAgregarArticulo.Text = "Agregar Articulo";
            btnAgregarArticulo.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarArticulo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarArticulo.UseVisualStyleBackColor = false;
            btnAgregarArticulo.Click += btnAgregarArticulo_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(58, 526);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(958, 230);
            dataGridView1.TabIndex = 54;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(587, 77);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(245, 33);
            cmbDepartamento.TabIndex = 53;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 0);
            label9.Name = "label9";
            label9.Size = new Size(223, 32);
            label9.TabIndex = 52;
            label9.Text = "Editar Requisición";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(454, 207);
            label8.Name = "label8";
            label8.Size = new Size(128, 25);
            label8.TabIndex = 51;
            label8.Text = "Observaciones";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 147);
            label7.Name = "label7";
            label7.Size = new Size(137, 25);
            label7.TabIndex = 50;
            label7.Text = "Id de Remitente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 212);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 49;
            label6.Text = "Fecha Límite";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(515, 145);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 48;
            label4.Text = "Evento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 85);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 47;
            label3.Text = "Departamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 85);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 46;
            label2.Text = "Aprobador";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 167, 62);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 28;
            btnGuardar.Location = new Point(892, 312);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 44;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(587, 209);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(417, 88);
            txtObservaciones.TabIndex = 43;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(150, 206);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(245, 31);
            dateTimePicker1.TabIndex = 42;
            // 
            // cmbEvento
            // 
            cmbEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEvento.FormattingEnabled = true;
            cmbEvento.Items.AddRange(new object[] { "No especificar" });
            cmbEvento.Location = new Point(587, 142);
            cmbEvento.Name = "cmbEvento";
            cmbEvento.Size = new Size(245, 33);
            cmbEvento.TabIndex = 41;
            // 
            // cmbAprobador
            // 
            cmbAprobador.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAprobador.FormattingEnabled = true;
            cmbAprobador.Items.AddRange(new object[] { "No especificar" });
            cmbAprobador.Location = new Point(150, 82);
            cmbAprobador.Name = "cmbAprobador";
            cmbAprobador.Size = new Size(245, 33);
            cmbAprobador.TabIndex = 40;
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
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtObservaciones);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(cmbEvento);
            panel1.Controls.Add(cmbAprobador);
            panel1.Location = new Point(27, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 418);
            panel1.TabIndex = 62;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonShadow;
            label12.Location = new Point(20, 35);
            label12.Name = "label12";
            label12.Size = new Size(291, 25);
            label12.TabIndex = 64;
            label12.Text = "Editar campos de la requisición";
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(0, 167, 62);
            label11.Location = new Point(-10, 446);
            label11.Name = "label11";
            label11.Size = new Size(1191, 10);
            label11.TabIndex = 63;
            // 
            // FormEditarRequisicion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 768);
            Controls.Add(label11);
            Controls.Add(panel1);
            Controls.Add(btnBorrarArticulo);
            Controls.Add(btnAgregarArticulo);
            Controls.Add(dataGridView1);
            Name = "FormEditarRequisicion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditarRequisicion";
            Load += FormEditarRequisicion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label10;
        private Label label5;
        private Label label1;
        private TextBox txtRemitente;
        private FontAwesome.Sharp.IconButton btnBorrarArticulo;
        private FontAwesome.Sharp.IconButton btnAgregarArticulo;
        private DataGridView dataGridView1;
        private ComboBox cmbDepartamento;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtObservaciones;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbEvento;
        private ComboBox cmbAprobador;
        private Panel panel1;
        private Label label11;
        private Label label12;
    }
}