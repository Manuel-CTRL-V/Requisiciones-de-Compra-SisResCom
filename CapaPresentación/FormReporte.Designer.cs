namespace CapaPresentación
{
    partial class FormReporte
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
            button1 = new Button();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(26, 22);
            button1.Name = "button1";
            button1.Size = new Size(212, 43);
            button1.TabIndex = 0;
            button1.Text = "Generar PDF";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(396, 246);
            reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(1032, 320);
            panel1.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(0, 167, 62);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(244, 24);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(201, 39);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Ver reporte";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 432);
            Controls.Add(iconButton1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "FormReporte";
            Text = "Reporte";
            Load += FormReporte_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}