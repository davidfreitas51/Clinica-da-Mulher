using ClinicaDaMulher.Data;
using ClinicaDaMulher.Forms;

namespace ClinicaDaMulher.Controls
{
    public partial class VerConsultas : UserControl
    {
        private readonly MainForm mainForm;
        public VerConsultas(MainForm frm)
        {
            InitializeComponent();
            mainForm = frm;
            cbxMotivo.DataSource = DbWorker.ListarTabelaMotivos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {
            NovaConsultaForm novaConsulta = new NovaConsultaForm(mainForm);
            novaConsulta.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
