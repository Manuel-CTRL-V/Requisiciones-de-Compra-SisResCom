namespace CapaPresentación
{
    partial class FormMisRequisiciones
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
            label1 = new Label();
            dgvBorradores = new DataGridView();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnEnviar = new FontAwesome.Sharp.IconButton();
            btnBorrar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            dgvEnviadas = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvBorradores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEnviadas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 17);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 0;
            label1.Text = "Borradores";
            // 
            // dgvBorradores
            // 
            dgvBorradores.BackgroundColor = Color.White;
            dgvBorradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorradores.Location = new Point(24, 75);
            dgvBorradores.Name = "dgvBorradores";
            dgvBorradores.RowHeadersWidth = 62;
            dgvBorradores.Size = new Size(349, 449);
            dgvBorradores.TabIndex = 1;
            dgvBorradores.SelectionChanged += dgvBorradores_SelectionChanged;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.DeepSkyBlue;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(391, 75);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(112, 43);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Editar";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(0, 167, 62);
            btnEnviar.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btnEnviar.FlatAppearance.BorderSize = 3;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.ForeColor = Color.FromArgb(192, 255, 192);
            btnEnviar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEnviar.IconColor = Color.Black;
            btnEnviar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEnviar.Location = new Point(391, 175);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(112, 44);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.FlatAppearance.BorderColor = Color.OrangeRed;
            btnBorrar.FlatAppearance.BorderSize = 3;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.ForeColor = Color.OrangeRed;
            btnBorrar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBorrar.IconColor = Color.Black;
            btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrar.Location = new Point(391, 124);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(112, 45);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += iconButton3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(531, 17);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 5;
            label2.Text = "Enviadas";
            // 
            // dgvEnviadas
            // 
            dgvEnviadas.BackgroundColor = Color.White;
            dgvEnviadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnviadas.Location = new Point(531, 75);
            dgvEnviadas.Name = "dgvEnviadas";
            dgvEnviadas.RowHeadersWidth = 62;
            dgvEnviadas.Size = new Size(349, 449);
            dgvEnviadas.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvEnviadas);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnBorrar);
            panel1.Controls.Add(btnEnviar);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(dgvBorradores);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(50, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 544);
            panel1.TabIndex = 7;
            // 
            // FormMisRequisiciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 570);
            Controls.Add(panel1);
            Name = "FormMisRequisiciones";
            Text = "FormMisRequisiciones";
            Load += FormMisRequisiciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorradores).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEnviadas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvBorradores;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnEnviar;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private Label label2;
        private DataGridView dgvEnviadas;
        private Panel panel1;
    }
}