using ClinicaDaMulher.Data;
using ClinicaDaMulher.Forms;
using ClinicaDaMulher.Models;

namespace ClinicaDaMulher.Controls
{
    public partial class VerConsultas : UserControl
    {
        private readonly MainForm mainForm;
        private readonly IClinicaDaMulherContext context;

        public VerConsultas(MainForm frm)
        {
            InitializeComponent();
            mainForm = frm;
            context = frm.context;
        }
        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {
            NovaConsultaForm novaConsulta = new NovaConsultaForm(mainForm);
            novaConsulta.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mainForm.RefreshGrid(DbWorker.ListarTabelaConsultas(context,
                txtNome.Text, txtCpf.Text, mtxDia.Text, cbxMotivo.Text));
        }

        private void VerConsultas_Load(object sender, EventArgs e)
        {
            cbxMotivo.DataSource = DbWorker.ListarMotivos(context);
            cbxMotivo.Text = "";
        }

        private void btnExcluirConsulta_Click(object sender, EventArgs e)
        {
            mainForm.ExcluirDados(typeof(Consulta));
        }

        private void btnEditarConsulta_Click(object sender, EventArgs e)
        {
            mainForm.EditarDados(typeof(Consulta));
        }
    }
}
