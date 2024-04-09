using ClinicaDaMulher.Data;
using ClinicaDaMulher.Models;
using MessageUtils;

namespace ClinicaDaMulher.Forms
{
    public partial class NovoClienteForm : Form
    {
        private readonly MainForm mainForm;
        private readonly IClinicaDaMulherContext context;

        public NovoClienteForm(MainForm frm)
        {
            InitializeComponent();
            mainForm = frm;
            context = frm.context;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (VerificarValidadeDosCampos())
            {
                CriarNovoCliente();
                SimpleMessage.Inform("Cliente cadastrado com sucesso!");
                AtualizarGridClientes();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (VerificarAlteracoesNaoSalvas())
            {
                this.Close();
            }
        }
        private bool VerificarValidadeDosCampos()
        {
            string cpfNumerico = new string(mtxCpf.Text.Where(char.IsDigit).ToArray());
            string mensagemDeErro = "";
            if (!DbWorker.VerificarCpfValido(context, mtxCpf.Text))
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

            if (mtxCpf == null || string.IsNullOrEmpty(mtxCpf.Text))
            {
                return false;
            }
            if (txtNome == null || string.IsNullOrEmpty(txtNome.Text))
            {
                return false;
            }
            if (mtxTelefone == null || string.IsNullOrEmpty(mtxTelefone.Text))
            {
                return false;
            }
            return true;
        }

        private bool VerificarAlteracoesNaoSalvas()
        {
            if (VerificarPreenchimentoDosCampos() &&
                !SimpleMessage.Confirm("Há alterações não salvas. Deseja mesmo cancelar?"))
            {
                return false;
            }
            return true;
        }
        private void CriarNovoCliente()
        {
            Cliente novoCliente = new Cliente
            {
                Nome = txtNome.Text,
                CPF = mtxCpf.Text,
                Telefone = mtxTelefone.Text,
            };
            DbWorker.CriarCliente(context, novoCliente);
        }
        private void AtualizarGridClientes()
        {
            mainForm.RefreshGrid(DbWorker.ListarTabelaClientes(context));
        }
    }
}
