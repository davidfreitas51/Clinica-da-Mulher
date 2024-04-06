using ClinicaDaMulher.Data;
using MessageUtils;
namespace ClinicaDaMulher.Forms
{
    public partial class NovoClienteForm : Form
    {
        private readonly MainForm mainForm;
        public NovoClienteForm(MainForm frm)
        {
            InitializeComponent();

            mainForm = frm;
        }
        private bool VerificarValidadeDosCampos()
        {
            if (!DbWorker.VerificarCpfValido(mtxCpf.Text))
            {
                SimpleMessage.Error("Já existe um cliente com esse CPF");
                return false;
            }
            else if (mtxCpf.Text.Length != 14)
            {
                SimpleMessage.Error("Insira um CPF válido");
                return false;
            }
            return true;
        }
        private bool VerificarPreenchimentoDosCampos()
        {

            if (txtCpf != null && !string.IsNullOrEmpty(txtCpf.Text))
            {
                return true;
            }

            if (txtNome != null && !string.IsNullOrEmpty(txtNome.Text))
            {
                return true;
            }
            return false;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (VerificarValidadeDosCampos())
            {
                List<string> novoCliente = new List<string>();
                novoCliente.Add(txtNome.Text);
                novoCliente.Add(mtxCpf.Text);
                novoCliente.Add(mtxTelefone.Text);
                DbWorker.CriarCliente(novoCliente);

                SimpleMessage.Inform("Cliente cadastrado com sucesso!");
                mainForm.RefreshGridCliente(DbWorker.ListarTabelaClientes());
                this.Close();
            }
        }

        private void NovoClienteForm_Load(object sender, EventArgs e)
        {
            List<string> unidadesFederativas = new List<string> {
                "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG",
                "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"
            };
            cbxEstado.DataSource = unidadesFederativas;
            cbxEstado.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (VerificarPreenchimentoDosCampos())
            {
                if (SimpleMessage.Confirm("Há alterações não salvas. Deseja mesmo cancelar?"))
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
