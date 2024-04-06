using ClinicaDaMulher.Models;
using Maroquio;

namespace ClinicaDaMulher.Controls
{
    public partial class PainelConsultas : UserControl
    {
        private readonly MainForm mainForm;
        public PainelConsultas(MainForm frm, SortableBindingList<Consulta> consultas)
        {
            InitializeComponent();
            mainForm = frm;
            dgvConsultas.AutoGenerateColumns = false;
            dgvConsultas.DataSource = consultas;

        }

        private void dgvConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}