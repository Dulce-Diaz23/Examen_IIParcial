using Datoss;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;
namespace Vista
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }

        string tipoOperacion;
        DataTable dt = new DataTable();
        UsuarioDB usuarioDB = new UsuarioDB();

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            CodigoUsuarioTextBox.Focus();
            HabilitarControles();
            tipoOperacion = "Agregar";
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }

        private void HabilitarControles()
        {
            CodigoUsuarioTextBox.Enabled = true;
            NombreUsuarioTextBox.Enabled = true;
            CorreoUsuarioTextBox.Enabled = true;
            ContrasenaUsuarioTextBox.Enabled = true;
            RolComboBox.Enabled = true;
            EstaActivoCheckBox.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            ModificarButton.Enabled = false;

        }

        private void DesabilitarControles()
        {
            CodigoUsuarioTextBox.Enabled = false;
            NombreUsuarioTextBox.Enabled = false;
            CorreoUsuarioTextBox.Enabled = false;
            ContrasenaUsuarioTextBox.Enabled = false;
            RolComboBox.Enabled = false;
            EstaActivoCheckBox.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            ModificarButton.Enabled = true;
        }

        private void LimpiarControles()
        {
            CodigoUsuarioTextBox.Clear();
            NombreUsuarioTextBox.Clear();
            CorreoUsuarioTextBox.Clear();
            ContrasenaUsuarioTextBox.Clear();
            RolComboBox.Text = string.Empty;
            EstaActivoCheckBox.Checked = false;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            if (tipoOperacion == "Nuevo")
            {

                if (string.IsNullOrEmpty(CodigoUsuarioTextBox.Text))
                {
                    errorProvider1.SetError(CodigoUsuarioTextBox, "Ingrese un código");
                    CodigoUsuarioTextBox.Focus();
                    return;
                }

                errorProvider1.Clear();

                if (string.IsNullOrEmpty(NombreUsuarioTextBox.Text))
                {
                    errorProvider1.SetError(NombreUsuarioTextBox, "Ingrese un nombre");
                    NombreUsuarioTextBox.Focus();
                    return;
                }

                errorProvider1.Clear();



                if (string.IsNullOrEmpty(ContrasenaUsuarioTextBox.Text))
                {
                    errorProvider1.SetError(ContrasenaUsuarioTextBox, "Ingrese un contrasena");
                    ContrasenaUsuarioTextBox.Focus();
                    return;
                }

                errorProvider1.Clear();

                if (string.IsNullOrEmpty(RolComboBox.Text))
                {
                    errorProvider1.SetError(RolComboBox, "Seleccione un rol");
                    RolComboBox.Focus();
                    return;
                }

                errorProvider1.Clear();

                user.CodigoUsuario = CodigoUsuarioTextBox.Text;
                user.Nombre = NombreUsuarioTextBox.Text;
                user.Contrasena = ContrasenaUsuarioTextBox.Text;
                user.Rol = RolComboBox.Text;
                user.Correo = CorreoUsuarioTextBox.Text;
                user.EstaActivo = EstaActivoCheckBox.Checked;



                bool inserto = usuarioDB.Insertar(user);

                if (inserto)
                {
                    LimpiarControles();
                    DesabilitarControles();
                    TraerUsuarios();

                    MessageBox.Show("Registro guardado");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro");
                }

            }

            else if (tipoOperacion == "Modificar")
            {
                user.CodigoUsuario = CodigoUsuarioTextBox.Text;
                user.Nombre = NombreUsuarioTextBox.Text;
                user.Contrasena = ContrasenaUsuarioTextBox.Text;
                user.Correo = CorreoUsuarioTextBox.Text;
                user.Rol = RolComboBox.Text;
                user.EstaActivo = EstaActivoCheckBox.Checked;

                bool modifico = usuarioDB.Editar(user);
                if (modifico)
                {
                    LimpiarControles();
                    DesabilitarControles();
                    TraerUsuarios();
                    MessageBox.Show("Registro actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el registro");
                }
            }
        }


        private void ModificarButton_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Modificar";

            if (UsuariosDataGridView1.SelectedRows.Count > 0)
            {
                CodigoUsuarioTextBox.Text = UsuariosDataGridView1.CurrentRow.Cells["CodigoUsuario"].Value.ToString();
                NombreUsuarioTextBox.Text = UsuariosDataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                ContrasenaUsuarioTextBox.Text = UsuariosDataGridView1.CurrentRow.Cells["Contrasena"].Value.ToString();
                CorreoUsuarioTextBox.Text = UsuariosDataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                RolComboBox.Text = UsuariosDataGridView1.CurrentRow.Cells["Rol"].Value.ToString();
                EstaActivoCheckBox.Text = UsuariosDataGridView1.CurrentRow.Cells["EstaActivo"].Value.ToString();


                HabilitarControles();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            TraerUsuarios();
        }

        private void TraerUsuarios()
        {
            dt = usuarioDB.DevolverUsuarios();
            UsuariosDataGridView1.DataSource = dt;
        }
    }
}
