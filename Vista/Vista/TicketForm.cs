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
        TicketDB ticketDB = new TicketDB();
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

                totalPagar += detalleTicket.Total;
                totalPagar = Convert.ToInt32(PrecioTextBox.Text);
                isv = totalPagar * 0.15M;
                totalPagar += Convert.ToInt32(PrecioTextBox.Text) + isv;

                detalleTickets.Add(detalleTicket);
                DetalleDataGridView.DataSource = null;
                DetalleDataGridView.DataSource = detalleTickets;

                TotalTextBox.Text = totalPagar.ToString();
                isvTextBox.Text = isv.ToString();


                TipoSoporteComboBox.Text = string.Empty;
                ArticuloComboBox.Text = string.Empty;
                SolicitudTextBox.Clear();
                RespuestaTextBox.Clear();
                PrecioTextBox.Clear();
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket tick = new Ticket();
                tick.Fecha = FechaDateTimePicker.Value;
                tick.CodigoUsuario = System.Threading.Thread.CurrentPrincipal.Identity.Name;
                tick.IdentidadCliente = miClientes.Identidad;
                tick.Total = totalPagar;
                tick.ISV = isv;
                tick.Descuento = descuento;

                bool inserto = ticketDB.Guardar(tick, detalleTickets);

                if (inserto)
                {
                    LimpiarControles();
                    IdentidadTextBox.Focus();
                    MessageBox.Show("Ticket registrado exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo registrar ticket");
                }

            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
        private void LimpiarControles()
        {
            miClientes = null;
            detalleTickets = null;
            FechaDateTimePicker.Value = DateTime.Now;
            IdentidadTextBox.Clear();
            NombreClienteTextBox.Clear();
            TipoSoporteComboBox.Text = string.Empty;
            ArticuloComboBox.Text = string.Empty;
            SolicitudTextBox.Clear();
            RespuestaTextBox.Clear();
            PrecioTextBox.Clear();
            isvTextBox.Clear();
            isv = 0;
            DescuentoTextBox.Clear();
            descuento = 0;
        }

        private void DescuentoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if (!char.IsDigit(e.KeyChar) && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
