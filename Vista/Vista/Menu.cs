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
            ClienteForm clienteForm = new ClienteForm();
            clienteForm.MdiParent = this;
            clienteForm.Show();
        }

        private void TicketToolStripButton_Click(object sender, System.EventArgs e)
        {
            TicketForm ticketForm = new TicketForm();
            ticketForm.MdiParent = this;
            ticketForm.Show();
        }
    }
}
