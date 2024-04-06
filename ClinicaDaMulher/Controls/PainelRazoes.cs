using ClinicaDaMulher.Models;
using Maroquio;

namespace ClinicaDaMulher.Controls
{
    public partial class PainelRazoes : UserControl
    {
        private readonly MainForm mainForm;
        public PainelRazoes(MainForm frm, SortableBindingList<Razao> razoes)
        {
            InitializeComponent();
            mainForm = frm;
            dgvRazoes.AutoGenerateColumns = false;
            dgvRazoes.DataSource = razoes;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
