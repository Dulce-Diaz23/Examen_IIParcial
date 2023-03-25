using Datoss;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class BusquedaClienteForm : Form
    {
        public BusquedaClienteForm()
        {
            InitializeComponent();
        }

        ClienteDB clienteDB = new ClienteDB();
        public Cliente cliente = new Cliente();

        private void BusquedaClienteForm_Load(object sender, EventArgs e)
        {
            ClienteDataGridView.DataSource = clienteDB.DevolverClientes();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (ClienteDataGridView.SelectedRows.Count > 0)
            {
                cliente.Identidad = ClienteDataGridView.CurrentRow.Cells["Identidad"].Value.ToString();
                cliente.Nombre = ClienteDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                cliente.Telefono = ClienteDataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                cliente.Correo = ClienteDataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                cliente.Direccion = ClienteDataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                cliente.Identidad = ClienteDataGridView.CurrentRow.Cells["Identidad"].Value.ToString();
                cliente.FechaNacimiento = Convert.ToDateTime(ClienteDataGridView.CurrentRow.Cells["FechaNacimiento"].Value);
                cliente.EstaActivo = Convert.ToBoolean(ClienteDataGridView.CurrentRow.Cells["EstaActivo"].Value);
                this.Close();
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
