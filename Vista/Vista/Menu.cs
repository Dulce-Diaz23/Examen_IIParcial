using System.Windows.Forms;

namespace Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void UsuarioToolStripButton_Click(object sender, System.EventArgs e)
        {
            UsuarioForm usuarioForm = new UsuarioForm();
            usuarioForm.MdiParent = this;
            usuarioForm.Show();
        }

        private void ClienteToolStripButton_Click(object sender, System.EventArgs e)
        {
            Cliente clienteForm = new Cliente();
            clienteForm.MdiParent = this;
            clienteForm.Show();
        }

        private void TicketToolStripButton_Click(object sender, System.EventArgs e)
        {
            Ticket ticketForm = new Ticket();
            ticketForm.MdiParent = this;
            ticketForm.Show();
        }
    }
}
