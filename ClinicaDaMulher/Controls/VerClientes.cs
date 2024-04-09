using ClinicaDaMulher.Data;
using ClinicaDaMulher.Forms;

namespace ClinicaDaMulher.Controls
{
    public partial class VerClientes : UserControl
    {
        private readonly MainForm mainForm;
        private readonly IClinicaDaMulherContext context;
        public VerClientes(MainForm frm)
        {
            InitializeComponent();
            mainForm = frm;
            context = frm.context;
        }

        public void btnBuscar_Click_1(object sender, EventArgs e)
        {
            mainForm.RefreshGrid(DbWorker.ListarTabelaClientes(context, txtNome.Text.Trim(), txtCpf.Text.Trim()));
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mainForm.RefreshGrid(DbWorker.ListarTabelaClientes(context, txtNome.Text.Trim(), txtCpf.Text.Trim()));
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mainForm.RefreshGrid(DbWorker.ListarTabelaClientes(context, txtNome.Text.Trim(), txtCpf.Text.Trim()));
            }
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            NovoClienteForm novoClienteForm = new NovoClienteForm(mainForm);
            novoClienteForm.ShowDialog();
        }

        private void btnDeletarCliente_Click(object sender, EventArgs e)
        {
            mainForm.ExcluirDados(typeof (Models.Cliente)) ;
        }
    }
}
