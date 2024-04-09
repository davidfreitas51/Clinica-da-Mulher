using ClinicaDaMulher.Data;
using ClinicaDaMulher.Forms;

namespace ClinicaDaMulher.Controls
{
    public partial class VerMotivos : UserControl
    {
        private readonly MainForm mainForm;
        private readonly IClinicaDaMulherContext context;

        public VerMotivos(MainForm frm)
        {
            InitializeComponent();
            mainForm = frm;
            context = frm.context;
        }

        private void btnNovaRazao_Click(object sender, EventArgs e)
        {
            AbrirNovoMotivoForm();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AtualizarGridMotivos();
        }

        private void AbrirNovoMotivoForm()
        {
            using (var novoMotivo = new NovoMotivoForm(mainForm))
            {
                novoMotivo.ShowDialog();
            }
        }

        private void AtualizarGridMotivos()
        {
            mainForm.RefreshGrid(DbWorker.ListarTabelaMotivos(context, txtMotivo.Text.Trim()));
        }

        private void btnExcluirMotivo_Click(object sender, EventArgs e)
        {
            mainForm.ExcluirDados(typeof(Models.Motivo));
        }
    }
}
