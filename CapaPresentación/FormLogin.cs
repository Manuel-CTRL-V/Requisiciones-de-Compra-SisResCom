using CapaEntidades;
using CapaNegocio;
using System.Data;

namespace CapaPresentación
{
    public partial class FormLogin : Form
    {
        string placeholderUsuario = "Username";
        private string placeholderPassword = "Password";

        public FormLogin()
        {
            InitializeComponent();

        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnIngresar;
            this.CancelButton = btnSalir;

            textBox1.PlaceholderText = placeholderUsuario;
            textBox2.PlaceholderText = placeholderPassword;

            textBox2.PasswordChar = '•';

            btnVerContrasena.UseVisualStyleBackColor = false;
            btnVerContrasena.FlatAppearance.MouseOverBackColor = btnVerContrasena.BackColor;
            btnVerContrasena.FlatAppearance.MouseDownBackColor = btnVerContrasena.BackColor;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioServicio servicios = new UsuarioServicio();
            Usuario usuario = servicios.Listar().Where(u => u.NombreUsuario == textBox1.Text && u.PasswordHash == textBox2.Text).FirstOrDefault();


            if (usuario != null)
            {
                servicios.ActualizarAcceso(usuario.UsuarioID); // La fecha de acceso del usuario se actualiza a la de ese instante
                FormMenu form = new FormMenu(usuario); // Abre el form principal, junto con el usuario que inició sesión
                this.Hide();
                form.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Usuario no encontrado. Revise la contraseña");
            }

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void btnVerContrasena_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '•')
            {
                btnVerContrasena.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                textBox2.PasswordChar = '\0';
            }
            else if (textBox2.PasswordChar == '\0')
            {
                btnVerContrasena.IconChar = FontAwesome.Sharp.IconChar.Eye;
                textBox2.PasswordChar = '•';

            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
