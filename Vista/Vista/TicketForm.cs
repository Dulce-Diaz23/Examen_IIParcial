using Datoss;
using Entidades;
using Entidads;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vista
{
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        Cliente miClientes = null;
        ClienteDB clienteDB = new ClienteDB();
        List<DetalleTicket> detalleTickets = new List<DetalleTicket>();

        decimal isv = 0;
        decimal descuento = 0;
        decimal totalPagar = 0;
        decimal subTotal = 0;
        private void IdentidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(IdentidadTextBox.Text))
            {
                miClientes = new Cliente();
                miClientes = clienteDB.DevolverClientePorIdentidad(IdentidadTextBox.Text);
                NombreClienteTextBox.Text = miClientes.Nombre;
            }
            else
            {
                miClientes = null;
                NombreClienteTextBox.Clear();
            }

        }

        private void BuscarClienteButton_Click(object sender, System.EventArgs e)
        {
            BusquedaClienteForm form = new BusquedaClienteForm();
            form.ShowDialog();
            miClientes = new Cliente();
            miClientes = form.cliente;
            IdentidadTextBox.Text = miClientes.Identidad;
            NombreClienteTextBox.Text = miClientes.Nombre;
        }

        private void TicketForm_Load(object sender, System.EventArgs e)
        {
            UsuarioTextBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        }

        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(PrecioTextBox.Text))
            {
                DetalleTicket detalleTicket = new DetalleTicket();
                detalleTicket.TipoSoporte = TipoSoporteComboBox.Text;
                detalleTicket.Articulo = ArticuloComboBox.Text;
                detalleTicket.Solicitud = SolicitudTextBox.Text;
                detalleTicket.Respuesta = RespuestaTextBox.Text;

                detalleTicket.precio = Convert.ToDecimal(PrecioTextBox.Text);
                //detalleTicket.Total = Convert.ToInt32(TotalTextBox.Text);
                detalleTickets.Add(detalleTicket);
                DetalleDataGridView.DataSource = null;
                DetalleDataGridView.DataSource = detalleTicket;

                TotalTextBox.Text = totalPagar.ToString();
                isvTextBox.Text = isv.ToString();

                detalleTickets.Add(detalleTicket);
                DetalleDataGridView.DataSource = null;
                DetalleDataGridView.DataSource = detalleTickets;

                isvTextBox.Text = isv.ToString();
                TotalTextBox.Text = totalPagar.ToString();
            }
        }
    }
}
