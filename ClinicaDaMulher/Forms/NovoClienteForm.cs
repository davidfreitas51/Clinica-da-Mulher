using ClinicaDaMulher.Data;
using ClinicaDaMulher.Models;
using MessageUtils;
using System.Text.RegularExpressions;

namespace ClinicaDaMulher.Forms
{
    public partial class NovoClienteForm : Form
    {
        private readonly MainForm mainForm;
        private readonly IClinicaDaMulherContext context;
        private readonly Cliente clienteAEditar;
        private bool ModoEdicao;
        public NovoClienteForm(MainForm frm, bool modoEdicao = false, Cliente clienteAnterior = null)
        {
            InitializeComponent();
            mainForm = frm;
            context = frm.context;
            ModoEdicao = modoEdicao;
            if (ModoEdicao)
            {
                lblTitulo.Text = "Editar cliente";
                clienteAEditar = clienteAnterior;
                btnCadastrar.Text = "Editar";
            }
        }
        private void NovoClienteForm_Load(object sender, EventArgs e)
        {
            if (ModoEdicao)
            {
                txtNome.Text = clienteAEditar.Nome;
                mtxCpf.Text = clienteAEditar.CPF;
                mtxCpf.Enabled = false;
                mtxTelefone.Text = clienteAEditar.Telefone;
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ModoEdicao)
            {
                EditarCliente();
                SimpleMessage.Inform("Cliente editado com sucesso");
                AtualizarGridClientes();
                this.Close();
            }
            else if (VerificarValidadeDosCampos())
            {
                CriarNovoCliente();
                SimpleMessage.Inform("Cliente cadastrado com sucesso");
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
            string mensagemDeErro = "";
            if (!DbWorker.VerificarValidadeDeCPF(context, mtxCpf.Text))
            {
                mensagemDeErro = "Já existe um cliente com esse CPF";
            }
            if (RemoverLiterais(mtxCpf.Text).Length != 11)
            {
                mensagemDeErro = "Insira um CPF válido";
            }
            if (txtNome.Text.Length < 3)
            {
                mensagemDeErro = "Insira um nome válido";
            }
            if (RemoverLiterais(mtxTelefone.Text).Length < 10)
            {
                mensagemDeErro = "Insira um telefone válido";
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
            if (txtNome.Text.Length > 0)
            {
                return false;
            }
            if (RemoverLiterais(mtxCpf.Text).Length > 0)
            {
                return false;
            }
            if (RemoverLiterais(mtxTelefone.Text).Length > 0)
            {
                return false;
            }
            return true;
        }

        private bool VerificarAlteracoesNaoSalvas()
        {
            if (!VerificarPreenchimentoDosCampos() &&
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
            DbWorker.CriarEntidade(context, novoCliente);
        }
        private void EditarCliente()
        {
            Cliente clienteEditado = new Cliente
            {
                Nome = txtNome.Text,
                CPF = mtxCpf.Text,
                Telefone = mtxTelefone.Text,
            };
            DbWorker.EditarCliente(context, clienteAEditar, clienteEditado);
        }
        private void AtualizarGridClientes()
        {
            mainForm.RefreshGrid(DbWorker.ListarTabelaClientes(context));
        }
        private static string RemoverLiterais(string input)
        {
            return Regex.Replace(input, @"[^\d]", "");
        }
    }
}
