using ClinicaDaMulher.Controls;
using ClinicaDaMulher.Data;
using ClinicaDaMulher.Models;
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
            string cpfNumerico = new string(mtxCpf.Text.Where(char.IsDigit).ToArray());
            string mensagemDeErro = "";
            if (!DbWorker.VerificarCpfValido(mtxCpf.Text))
            {
                mensagemDeErro = "Já existe um cliente com esse CPF";
            }
            if (cpfNumerico.Length != 11)
            {
                mensagemDeErro = "Insira um CPF válido";
            }
            if (txtNome.Text.Length <= 2)
            {
                mensagemDeErro = "Insira um nome válido";
            }
            if (!string.IsNullOrEmpty(mensagemDeErro))
            {
                SimpleMessage.Error(mensagemDeErro);
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
    }
}
