namespace CapaPresentación
{
    partial class FormAdmRequisiciones
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
            label1 = new Label();
            txtRemitente = new TextBox();
            cmbDepartamento = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtObservaciones = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cmbEvento = new ComboBox();
            cmbVista = new ComboBox();
            btnRechazar = new Button();
            btnEnviarARevision = new Button();
            btnAprobar = new Button();
            txtComentarios = new TextBox();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(295, 564);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(698, 105);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 53;
            // 
            // txtRemitente
            // 
            txtRemitente.Enabled = false;
            txtRemitente.Location = new Point(146, 27);
            txtRemitente.Name = "txtRemitente";
            txtRemitente.Size = new Size(64, 31);
            txtRemitente.TabIndex = 52;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.Enabled = false;
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(400, 27);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(245, 33);
            cmbDepartamento.TabIndex = 51;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(45, 19);
            label9.Name = "label9";
            label9.Size = new Size(309, 32);
            label9.TabIndex = 50;
            label9.Text = "Requisiciones Pendientes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(0, 167, 62);
            label8.Location = new Point(27, 215);
            label8.Name = "label8";
            label8.Size = new Size(128, 25);
            label8.TabIndex = 49;
            label8.Text = "Observaciones";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 27);
            label7.Name = "label7";
            label7.Size = new Size(137, 25);
            label7.TabIndex = 48;
            label7.Text = "Id de Remitente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 160);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 47;
            label6.Text = "Fecha Límite";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 87);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 46;
            label4.Text = "Evento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 27);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 45;
            label3.Text = "Departamento";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Enabled = false;
            txtObservaciones.Location = new Point(27, 258);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(246, 88);
            txtObservaciones.TabIndex = 43;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(142, 160);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(503, 31);
            dateTimePicker1.TabIndex = 42;
            // 
            // cmbEvento
            // 
            cmbEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEvento.Enabled = false;
            cmbEvento.FormattingEnabled = true;
            cmbEvento.Items.AddRange(new object[] { "No especificar" });
            cmbEvento.Location = new Point(400, 79);
            cmbEvento.Name = "cmbEvento";
            cmbEvento.Size = new Size(245, 33);
            cmbEvento.TabIndex = 41;
            // 
            // cmbVista
            // 
            cmbVista.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVista.FormattingEnabled = true;
            cmbVista.Items.AddRange(new object[] { "Para mí", "General" });
            cmbVista.Location = new Point(45, 68);
            cmbVista.Name = "cmbVista";
            cmbVista.Size = new Size(295, 33);
            cmbVista.TabIndex = 57;
            cmbVista.SelectedIndexChanged += cmbVista_SelectedIndexChanged;
            // 
            // btnRechazar
            // 
            btnRechazar.BackColor = Color.OrangeRed;
            btnRechazar.FlatAppearance.BorderSize = 0;
            btnRechazar.FlatStyle = FlatStyle.Flat;
            btnRechazar.ForeColor = Color.White;
            btnRechazar.Location = new Point(688, 699);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(112, 42);
            btnRechazar.TabIndex = 58;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = false;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // btnEnviarARevision
            // 
            btnEnviarARevision.BackColor = Color.White;
            btnEnviarARevision.FlatAppearance.BorderSize = 2;
            btnEnviarARevision.FlatStyle = FlatStyle.Flat;
            btnEnviarARevision.ForeColor = Color.FromArgb(0, 167, 62);
            btnEnviarARevision.Location = new Point(560, 699);
            btnEnviarARevision.Name = "btnEnviarARevision";
            btnEnviarARevision.Size = new Size(112, 42);
            btnEnviarARevision.TabIndex = 59;
            btnEnviarARevision.Text = "Devolver ";
            btnEnviarARevision.UseVisualStyleBackColor = false;
            btnEnviarARevision.Click += btnEnviarARevision_Click;
            // 
            // btnAprobar
            // 
            btnAprobar.BackColor = Color.FromArgb(0, 167, 62);
            btnAprobar.FlatAppearance.BorderSize = 0;
            btnAprobar.FlatStyle = FlatStyle.Flat;
            btnAprobar.ForeColor = Color.White;
            btnAprobar.Location = new Point(925, 699);
            btnAprobar.Name = "btnAprobar";
            btnAprobar.Size = new Size(112, 42);
            btnAprobar.TabIndex = 60;
            btnAprobar.Text = "Aprobar";
            btnAprobar.UseVisualStyleBackColor = false;
            btnAprobar.Click += btnAprobar_Click;
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(293, 258);
            txtComentarios.Multiline = true;
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(360, 88);
            txtComentarios.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 167, 62);
            label2.Location = new Point(271, 215);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 62;
            label2.Text = "Comentarios";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(27, 403);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(626, 215);
            dataGridView2.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 167, 62);
            label5.Location = new Point(27, 366);
            label5.Name = "label5";
            label5.Size = new Size(246, 25);
            label5.TabIndex = 64;
            label5.Text = "Articulos de la requisición";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtComentarios);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtRemitente);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmbDepartamento);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtObservaciones);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(cmbEvento);
            panel1.Location = new Point(359, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 633);
            panel1.TabIndex = 65;
            // 
            // FormAdmRequisiciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 753);
            Controls.Add(panel1);
            Controls.Add(btnAprobar);
            Controls.Add(btnEnviarARevision);
            Controls.Add(btnRechazar);
            Controls.Add(cmbVista);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            Name = "FormAdmRequisiciones";
            Text = "FormAdmRequisiciones";
            Load += FormAdmRequisiciones_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtRemitente;
        private ComboBox cmbDepartamento;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox txtObservaciones;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbEvento;
        private ComboBox cmbVista;
        private Button btnRechazar;
        private Button btnEnviarARevision;
        private Button btnAprobar;
        private TextBox txtComentarios;
        private Label label2;
        private DataGridView dataGridView2;
        private Label label5;
        private Panel panel1;
    }
}