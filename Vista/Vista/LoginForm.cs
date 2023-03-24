using Datoss;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            if (NombreUsuarioTextBox.Text == "")
            {
                errorProvider1.SetError(NombreUsuarioTextBox, "Ingrese un usuario");
                NombreUsuarioTextBox.Focus();
                return;
            }

            if (ContrasenaTextBox.Text == "")
            {
                errorProvider1.SetError(ContrasenaTextBox, "Ingrese una contrasena");
                NombreUsuarioTextBox.Focus();
                return;
            }

            errorProvider1.Clear();


            Login login = new Login(NombreUsuarioTextBox.Text, ContrasenaTextBox.Text);
            Usuario usuario = new Usuario();
            UsuarioDB usuarioDB = new UsuarioDB();

            usuario = usuarioDB.Autenticar(login);

            if (usuario != null)
            {
                if (usuario.EstaActivo)
                {
                    System.Security.Principal.GenericIdentity identidad = new System.Security.Principal.GenericIdentity(usuario.CodigoUsuario);
                    System.Security.Principal.GenericPrincipal principal = new System.Security.Principal.GenericPrincipal(identidad, new string[] { usuario.Rol });
                    System.Threading.Thread.CurrentPrincipal = principal;


                    Menu menuFormulario = new Menu();
                    Hide();
                    menuFormulario.Show();

                }
                else
                {
                    MessageBox.Show("El usuario no esta activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Datos del usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void VistaButton_Click(object sender, EventArgs e)
        {

            if (ContrasenaTextBox.PasswordChar == '*')
            {
                ContrasenaTextBox.PasswordChar = '\0';
            }
            else
            {
                ContrasenaTextBox.PasswordChar = '*';
            }
        }


    }
}
