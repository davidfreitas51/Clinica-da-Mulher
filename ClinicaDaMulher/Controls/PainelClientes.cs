using ClinicaDaMulher.Models;
using Maroquio;

namespace ClinicaDaMulher.Controls
{
    public partial class PainelClientes : UserControl
    {
        private readonly MainForm mainForm;
        public PainelClientes(MainForm frm, SortableBindingList<Cliente> clientes)
        {
            InitializeComponent();
            mainForm = frm;
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = clientes;
        }
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
