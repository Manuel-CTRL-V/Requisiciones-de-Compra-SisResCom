namespace CapaPresentación
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            menuRequisiciones = new FontAwesome.Sharp.IconMenuItem();
            opNuevaRequisicion = new FontAwesome.Sharp.IconMenuItem();
            opMisRequisiciones = new FontAwesome.Sharp.IconMenuItem();
            menuRequisicionesAdmin = new FontAwesome.Sharp.IconMenuItem();
            opAdministrar = new FontAwesome.Sharp.IconMenuItem();
            menuEmpleados = new FontAwesome.Sharp.IconMenuItem();
            opRegistroEmpleados = new FontAwesome.Sharp.IconMenuItem();
            opConsultarEmpleados = new FontAwesome.Sharp.IconMenuItem();
            menuReportes = new FontAwesome.Sharp.IconMenuItem();
            opRequisicionesAprobadas = new FontAwesome.Sharp.IconMenuItem();
            menuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            panel1 = new Panel();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(28, 41, 60);
            menu.Dock = DockStyle.Left;
            menu.Font = new Font("Rubik", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu.ImageScalingSize = new Size(24, 24);
            menu.Items.AddRange(new ToolStripItem[] { iconMenuItem1, menuRequisiciones, menuRequisicionesAdmin, menuEmpleados, menuReportes, menuAcercaDe });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(304, 814);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.Font = new Font("Segoe UI", 20F, FontStyle.Italic, GraphicsUnit.Point, 0);
            iconMenuItem1.ForeColor = Color.White;
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.FromArgb(177, 202, 222);
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 52;
            iconMenuItem1.ImageAlign = ContentAlignment.MiddleLeft;
            iconMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Padding = new Padding(10, 0, 10, 0);
            iconMenuItem1.Size = new Size(291, 58);
            iconMenuItem1.Text = "SisResCom";
            iconMenuItem1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menuRequisiciones
            // 
            menuRequisiciones.DropDownItems.AddRange(new ToolStripItem[] { opNuevaRequisicion, opMisRequisiciones });
            menuRequisiciones.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            menuRequisiciones.ForeColor = Color.FromArgb(177, 202, 222);
            menuRequisiciones.IconChar = FontAwesome.Sharp.IconChar.Shop;
            menuRequisiciones.IconColor = Color.FromArgb(177, 202, 222);
            menuRequisiciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuRequisiciones.IconSize = 52;
            menuRequisiciones.ImageAlign = ContentAlignment.MiddleLeft;
            menuRequisiciones.ImageScaling = ToolStripItemImageScaling.None;
            menuRequisiciones.Name = "menuRequisiciones";
            menuRequisiciones.Size = new Size(291, 56);
            menuRequisiciones.Text = "Requisiciones";
            menuRequisiciones.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // opNuevaRequisicion
            // 
            opNuevaRequisicion.IconChar = FontAwesome.Sharp.IconChar.Add;
            opNuevaRequisicion.IconColor = Color.Black;
            opNuevaRequisicion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            opNuevaRequisicion.Name = "opNuevaRequisicion";
            opNuevaRequisicion.Size = new Size(302, 40);
            opNuevaRequisicion.Text = "Nueva requisición";
            opNuevaRequisicion.Click += opNuevaRequisicion_Click;
            // 
            // opMisRequisiciones
            // 
            opMisRequisiciones.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            opMisRequisiciones.IconColor = Color.Black;
            opMisRequisiciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            opMisRequisiciones.Name = "opMisRequisiciones";
            opMisRequisiciones.Size = new Size(302, 40);
            opMisRequisiciones.Text = "Mis requisiciones";
            opMisRequisiciones.Click += opMisRequisiciones_Click;
            // 
            // menuRequisicionesAdmin
            // 
            menuRequisicionesAdmin.DropDownItems.AddRange(new ToolStripItem[] { opAdministrar });
            menuRequisicionesAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            menuRequisicionesAdmin.ForeColor = Color.FromArgb(177, 202, 222);
            menuRequisicionesAdmin.IconChar = FontAwesome.Sharp.IconChar.Tools;
            menuRequisicionesAdmin.IconColor = Color.FromArgb(177, 202, 222);
            menuRequisicionesAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuRequisicionesAdmin.IconSize = 52;
            menuRequisicionesAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            menuRequisicionesAdmin.ImageScaling = ToolStripItemImageScaling.None;
            menuRequisicionesAdmin.Name = "menuRequisicionesAdmin";
            menuRequisicionesAdmin.Size = new Size(291, 56);
            menuRequisicionesAdmin.Text = "Admin. Requisiciones";
            menuRequisicionesAdmin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // opAdministrar
            // 
            opAdministrar.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            opAdministrar.IconColor = Color.Black;
            opAdministrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            opAdministrar.Name = "opAdministrar";
            opAdministrar.Size = new Size(240, 40);
            opAdministrar.Text = "Administrar";
            opAdministrar.Click += opAdministrar_Click;
            // 
            // menuEmpleados
            // 
            menuEmpleados.DropDownItems.AddRange(new ToolStripItem[] { opRegistroEmpleados, opConsultarEmpleados });
            menuEmpleados.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            menuEmpleados.ForeColor = Color.FromArgb(177, 202, 222);
            menuEmpleados.IconChar = FontAwesome.Sharp.IconChar.User;
            menuEmpleados.IconColor = Color.FromArgb(177, 202, 222);
            menuEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuEmpleados.IconSize = 52;
            menuEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            menuEmpleados.ImageScaling = ToolStripItemImageScaling.None;
            menuEmpleados.Name = "menuEmpleados";
            menuEmpleados.Size = new Size(291, 56);
            menuEmpleados.Text = "Empleados";
            menuEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // opRegistroEmpleados
            // 
            opRegistroEmpleados.IconChar = FontAwesome.Sharp.IconChar.Save;
            opRegistroEmpleados.IconColor = Color.Black;
            opRegistroEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            opRegistroEmpleados.Name = "opRegistroEmpleados";
            opRegistroEmpleados.Size = new Size(218, 40);
            opRegistroEmpleados.Text = "Registrar ";
            opRegistroEmpleados.Click += opRegistroEmpleados_Click;
            // 
            // opConsultarEmpleados
            // 
            opConsultarEmpleados.IconChar = FontAwesome.Sharp.IconChar.HandPaper;
            opConsultarEmpleados.IconColor = Color.Black;
            opConsultarEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            opConsultarEmpleados.Name = "opConsultarEmpleados";
            opConsultarEmpleados.Size = new Size(218, 40);
            opConsultarEmpleados.Text = "Consultar";
            // 
            // menuReportes
            // 
            menuReportes.DropDownItems.AddRange(new ToolStripItem[] { opRequisicionesAprobadas });
            menuReportes.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            menuReportes.ForeColor = Color.FromArgb(177, 202, 222);
            menuReportes.IconChar = FontAwesome.Sharp.IconChar.Book;
            menuReportes.IconColor = Color.FromArgb(177, 202, 222);
            menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuReportes.IconSize = 52;
            menuReportes.ImageAlign = ContentAlignment.MiddleLeft;
            menuReportes.ImageScaling = ToolStripItemImageScaling.None;
            menuReportes.Name = "menuReportes";
            menuReportes.Size = new Size(291, 56);
            menuReportes.Text = "Reportes";
            menuReportes.TextAlign = ContentAlignment.MiddleLeft;
            menuReportes.Click += menuReportes_Click;
            // 
            // opRequisicionesAprobadas
            // 
            opRequisicionesAprobadas.IconChar = FontAwesome.Sharp.IconChar.None;
            opRequisicionesAprobadas.IconColor = Color.Black;
            opRequisicionesAprobadas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            opRequisicionesAprobadas.Name = "opRequisicionesAprobadas";
            opRequisicionesAprobadas.Size = new Size(372, 40);
            opRequisicionesAprobadas.Text = "Requisiciones Aprobadas";
            opRequisicionesAprobadas.Click += iconMenuItem1_Click;
            // 
            // menuAcercaDe
            // 
            menuAcercaDe.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            menuAcercaDe.ForeColor = Color.FromArgb(177, 202, 222);
            menuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            menuAcercaDe.IconColor = Color.FromArgb(177, 202, 222);
            menuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuAcercaDe.IconSize = 52;
            menuAcercaDe.ImageAlign = ContentAlignment.MiddleLeft;
            menuAcercaDe.ImageScaling = ToolStripItemImageScaling.None;
            menuAcercaDe.Name = "menuAcercaDe";
            menuAcercaDe.Size = new Size(291, 56);
            menuAcercaDe.Text = "Acerca De";
            menuAcercaDe.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(304, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 814);
            panel1.TabIndex = 1;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 814);
            Controls.Add(panel1);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SisResCom - Menu Principal";
            Load += FormMenu_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuRequisiciones;
        private FontAwesome.Sharp.IconMenuItem opNuevaRequisicion;
        private FontAwesome.Sharp.IconMenuItem opMisRequisiciones;
        private FontAwesome.Sharp.IconMenuItem menuEmpleados;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem menuAcercaDe;
        private Panel panel1;
        private ToolStripMenuItem requisicionesToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuRequisicionesAdmin;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private ToolStripMenuItem toolStripMenuItem1;
        private FontAwesome.Sharp.IconMenuItem opRegistroEmpleados;
        private FontAwesome.Sharp.IconMenuItem opConsultarEmpleados;
        private FontAwesome.Sharp.IconMenuItem opAdministrar;
        private FontAwesome.Sharp.IconMenuItem opRequisicionesAprobadas;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
    }
}
