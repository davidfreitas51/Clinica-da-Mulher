using ClinicaDaMulher.Data;
using ClinicaDaMulher.Forms;

namespace ClinicaDaMulher.Controls
{
    public partial class VerClientes : UserControl
    {
        private readonly MainForm mainForm;
        public VerClientes(MainForm frm)
        {
            InitializeComponent();
            mainForm = frm;
        }

        public void btnBuscar_Click_1(object sender, EventArgs e)
        {
            mainForm.RefreshGridCliente(DbWorker.ListarTabelaClientes(txtNome.Text.Trim(), txtCpf.Text.Trim()));
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mainForm.RefreshGridCliente(DbWorker.ListarTabelaClientes(txtNome.Text.Trim(), txtCpf.Text.Trim()));
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mainForm.RefreshGridCliente(DbWorker.ListarTabelaClientes(txtNome.Text.Trim(), txtCpf.Text.Trim()));
            }
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            NovoClienteForm novoClienteForm = new NovoClienteForm(mainForm);
            novoClienteForm.ShowDialog();
        }
    }
}
