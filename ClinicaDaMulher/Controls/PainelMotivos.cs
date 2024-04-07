using ClinicaDaMulher.Models;
using Maroquio;

namespace ClinicaDaMulher.Controls
{
    public partial class PainelMotivos : UserControl
    {
        private readonly MainForm mainForm;
        public PainelMotivos(MainForm frm, SortableBindingList<Motivo> razoes)
        {
            InitializeComponent();
            mainForm = frm;
            dgvMotivos.AutoGenerateColumns = false;
            dgvMotivos.DataSource = razoes;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMotivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
