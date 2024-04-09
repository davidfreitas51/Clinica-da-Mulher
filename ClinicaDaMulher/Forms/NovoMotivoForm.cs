using ClinicaDaMulher.Data;
using ClinicaDaMulher.Models;
using MessageUtils;
using System.Text.RegularExpressions;

namespace ClinicaDaMulher.Forms
{
    public partial class NovoMotivoForm : Form
    {
        private readonly MainForm mainForm;
        private readonly IClinicaDaMulherContext context;

        public NovoMotivoForm(MainForm frm)
        {
            InitializeComponent();
            mainForm = frm;
            context = frm.context;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarNome())
            {
                CriarNovoMotivo();
                SimpleMessage.Inform("Motivo criado com sucesso!");
                AtualizarGridMotivos();
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
        private bool VerificarAlteracoesNaoSalvas()
        {
            if (!VerificarPreenchimentoDosCampos() &&
                !SimpleMessage.Confirm("Há alterações não salvas. Deseja mesmo cancelar?"))
            {
                return false;
            }
            return true;
        }

        private bool ValidarNome()
        {
            string mensagemDeErro = "";
            if (VerificarPreenchimentoDosCampos())
            {
                mensagemDeErro = "O motivo precisa de um nome";
            }
            else if (!DbWorker.ValidarNomeDoMotivo(context, txtNomeDoMotivo.Text))
            {
                mensagemDeErro = "Um motivo com o mesmo nome já existe";
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
            return string.IsNullOrEmpty(txtNomeDoMotivo.Text);
        }

        private void CriarNovoMotivo()
        {
            Motivo novoMotivo = new Motivo
            {
                Nome = txtNomeDoMotivo.Text
            };
            DbWorker.CriarMotivo(context, novoMotivo);
        }

        private void AtualizarGridMotivos()
        {
            mainForm.RefreshGrid(DbWorker.ListarTabelaMotivos(context));
        }
    }
}
