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
            cbxMotivo.DataSource = DbWorker.ListarMotivos();
            cbxMotivo.Text = "";
        }
        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {
            NovaConsultaForm novaConsulta = new NovaConsultaForm(mainForm);
            novaConsulta.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mainForm.RefreshGridConsultas(DbWorker.ListarTabelaConsultas(txtNome.Text,
                txtCpf.Text, mtxDia.Text, cbxMotivo.Text));
        }

        private void pnlControlesConsultas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
