using Datoss;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }

        string tipoOperacion;

        ClienteDB clienteDB = new ClienteDB();
        DataTable data = new DataTable();

        private void HabilitarControles()
        {
            IdentidadClienteTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            CorreoTextBox.Enabled = true;
            TelefonoTextBox.Enabled = true;
            DireccionTextBox.Enabled = true;
            FechaNacimientoTextBox.Enabled = true;
            ContrasenaTextBox.Enabled = true;
            EstaActivoCheckBox.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            ModificarButton.Enabled = false;

        }

        private void DesabilitarControles()
        {
            IdentidadClienteTextBox.Enabled = false;
            NombreTextBox.Enabled = false;
            TelefonoTextBox.Enabled = false;
            CorreoTextBox.Enabled = false;
            DireccionTextBox.Enabled = false;
            FechaNacimientoTextBox.Enabled = false;
            EstaActivoCheckBox.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            ModificarButton.Enabled = true;
        }

        private void LimpiarControles()
        {
            IdentidadClienteTextBox.Clear();
            NombreTextBox.Clear();
            TelefonoTextBox.Clear();
            CorreoTextBox.Clear();
            DireccionTextBox.Clear();
            FechaNacimientoTextBox.Clear();
            EstaActivoCheckBox.Checked = false;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            IdentidadClienteTextBox.Focus();
            HabilitarControles();
            tipoOperacion = "Nuevo";
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }



        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (tipoOperacion == "Nuevo")
            {

                if (string.IsNullOrEmpty(IdentidadClienteTextBox.Text))
                {
                    errorProvider1.SetError(IdentidadClienteTextBox, "Ingrese numero de identidad");
                    IdentidadClienteTextBox.Focus();
                    return;
                }

                errorProvider1.Clear();

                if (string.IsNullOrEmpty(NombreTextBox.Text))
                {
                    errorProvider1.SetError(NombreTextBox, "Ingrese un nombre");
                    NombreTextBox.Focus();
                    return;
                }

                errorProvider1.Clear();


                if (string.IsNullOrEmpty(TelefonoTextBox.Text))
                {
                    errorProvider1.SetError(TelefonoTextBox, "Ingrese un numero telefonico");
                    TelefonoTextBox.Focus();
                    return;
                }

                errorProvider1.Clear();

                if (string.IsNullOrEmpty(CorreoTextBox.Text))
                {
                    errorProvider1.SetError(CorreoTextBox, "Ingrese un correo");
                    CorreoTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                cliente.Identidad = IdentidadClienteTextBox.Text;
                cliente.Nombre = NombreTextBox.Text;
                cliente.Telefono = TelefonoTextBox.Text;
                cliente.Correo = CorreoTextBox.Text;
                cliente.Direccion = DireccionTextBox.Text;
                cliente.FechaNacimiento = Convert.ToDateTime(FechaNacimientoTextBox.Text);
                cliente.EstaActivo = EstaActivoCheckBox.Checked;


                bool inserto = clienteDB.Insertar(cliente);

                if (inserto)
                {
                    LimpiarControles();
                    DesabilitarControles();
                    TraerCliente();

                    MessageBox.Show("Registro guardado");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro");
                }

            }

            else if (tipoOperacion == "Modificar")
            {
                cliente.Identidad = IdentidadClienteTextBox.Text;
                cliente.Nombre = NombreTextBox.Text;
                cliente.Telefono = TelefonoTextBox.Text;
                cliente.Correo = CorreoTextBox.Text;
                cliente.Direccion = DireccionTextBox.Text;
                cliente.FechaNacimiento = Convert.ToDateTime(FechaNacimientoTextBox.Text);
                cliente.EstaActivo = EstaActivoCheckBox.Checked;

                bool modifico = clienteDB.Editar(cliente);
                if (modifico)
                {
                    LimpiarControles();
                    DesabilitarControles();
                    TraerCliente();
                    MessageBox.Show("Registro actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro");
                }
            }
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            TraerCliente();
        }
        private void TraerCliente()
        {
            data = clienteDB.DevolverClientes();
            ClientesDataGridView.DataSource = data;
        }
        private void ModificarButton_Click(object sender, EventArgs e)
        {

            tipoOperacion = "Modificar";
            if (ClientesDataGridView.SelectedRows.Count > 0)
            {
                IdentidadClienteTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Identidad"].Value.ToString();
                NombreTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                TelefonoTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                CorreoTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                DireccionTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                FechaNacimientoTextBox.Text = ClientesDataGridView.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                EstaActivoCheckBox.Text = ClientesDataGridView.CurrentRow.Cells["EstaActivo"].Value.ToString();

                HabilitarControles();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (ClientesDataGridView.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Esta seguro de eliminar registro?", "Advertencia", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    bool elimino = clienteDB.Eliminar(ClientesDataGridView.CurrentRow.Cells["Identidad"].Value.ToString());
                    if (elimino)
                    {
                        LimpiarControles();
                        DesabilitarControles();
                        TraerCliente();
                        MessageBox.Show("Registro eliminado");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro");
                    }
                }

            }
        }


    }

}
