using ClinicaDaMulher.Models;
using Maroquio;

namespace ClinicaDaMulher.Controls
{
    public partial class PainelRazoes : UserControl
    {
        private readonly MainForm mainForm;
        public PainelRazoes(MainForm frm, SortableBindingList<Motivo> razoes)
        {
            InitializeComponent();
            mainForm = frm;
            dgvMotivos.AutoGenerateColumns = false;
            dgvMotivos.DataSource = razoes;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
