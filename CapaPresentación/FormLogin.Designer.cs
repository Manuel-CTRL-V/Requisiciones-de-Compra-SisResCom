namespace CapaPresentación
{
    partial class FormLogin
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            btnVerContrasena = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label5 = new Label();
            btnUser = new FontAwesome.Sharp.IconButton();
            btnPassword = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(28, 41, 60);
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(177, 202, 222);
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(222, 38);
            label1.TabIndex = 0;
            label1.Text = "Inicio de Sesión";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.BackColor = Color.FromArgb(243, 243, 245);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bilgen Demo Light", 8F);
            textBox1.ForeColor = Color.FromArgb(1, 101, 77);
            textBox1.Location = new Point(244, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 35);
            textBox1.TabIndex = 2;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.BackColor = Color.FromArgb(243, 243, 245);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Bilgen Demo Light", 8F);
            textBox2.ForeColor = Color.FromArgb(1, 101, 77);
            textBox2.Location = new Point(244, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 35);
            textBox2.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.Left;
            btnIngresar.BackColor = Color.FromArgb(192, 255, 192);
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(0, 167, 62);
            btnIngresar.FlatAppearance.BorderSize = 3;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.FromArgb(0, 167, 62);
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnIngresar.IconColor = Color.FromArgb(0, 167, 62);
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 30;
            btnIngresar.Location = new Point(222, 308);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(207, 49);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnVerContrasena
            // 
            btnVerContrasena.Anchor = AnchorStyles.Left;
            btnVerContrasena.BackColor = Color.FromArgb(177, 202, 222);
            btnVerContrasena.FlatAppearance.BorderSize = 0;
            btnVerContrasena.FlatStyle = FlatStyle.Flat;
            btnVerContrasena.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnVerContrasena.IconColor = Color.FromArgb(28, 41, 60);
            btnVerContrasena.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerContrasena.IconSize = 32;
            btnVerContrasena.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerContrasena.Location = new Point(423, 224);
            btnVerContrasena.Name = "btnVerContrasena";
            btnVerContrasena.Size = new Size(59, 37);
            btnVerContrasena.TabIndex = 5;
            btnVerContrasena.UseVisualStyleBackColor = false;
            btnVerContrasena.Click += btnVerContrasena_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.BackColor = Color.FromArgb(28, 41, 60);
            label4.Location = new Point(15, 15);
            label4.Name = "label4";
            label4.Size = new Size(304, 369);
            label4.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.BackColor = Color.FromArgb(177, 202, 222);
            label5.Location = new Point(316, 15);
            label5.Name = "label5";
            label5.Size = new Size(314, 369);
            label5.TabIndex = 8;
            // 
            // btnUser
            // 
            btnUser.Anchor = AnchorStyles.Left;
            btnUser.BackColor = Color.FromArgb(28, 41, 60);
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            btnUser.IconColor = Color.FromArgb(177, 202, 222);
            btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUser.IconSize = 32;
            btnUser.ImageAlign = ContentAlignment.MiddleRight;
            btnUser.Location = new Point(179, 140);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(59, 37);
            btnUser.TabIndex = 9;
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnPassword
            // 
            btnPassword.Anchor = AnchorStyles.Left;
            btnPassword.BackColor = Color.FromArgb(28, 41, 60);
            btnPassword.FlatAppearance.BorderSize = 0;
            btnPassword.FlatStyle = FlatStyle.Flat;
            btnPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            btnPassword.IconColor = Color.FromArgb(177, 202, 222);
            btnPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPassword.IconSize = 32;
            btnPassword.ImageAlign = ContentAlignment.MiddleRight;
            btnPassword.Location = new Point(179, 224);
            btnPassword.Name = "btnPassword";
            btnPassword.Size = new Size(59, 37);
            btnPassword.TabIndex = 10;
            btnPassword.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Left;
            btnSalir.BackColor = Color.DarkGray;
            btnSalir.FlatAppearance.BorderColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Bilgen Demo Black", 8F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            btnSalir.IconColor = Color.White;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 32;
            btnSalir.Location = new Point(23, 330);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(48, 43);
            btnSalir.TabIndex = 11;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 241, 245);
            ClientSize = new Size(652, 400);
            Controls.Add(btnSalir);
            Controls.Add(btnPassword);
            Controls.Add(btnUser);
            Controls.Add(btnVerContrasena);
            Controls.Add(btnIngresar);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnVerContrasena;
        private Label label4;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnPassword;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}