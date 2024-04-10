using ClinicaDaMulher.Data;
using ClinicaDaMulher.Models;
using MessageUtils;

namespace ClinicaDaMulher.Forms
{
    public partial class NovoMotivoForm : Form
    {
        private readonly MainForm mainForm;
        private readonly IClinicaDaMulherContext context;
        private readonly Motivo motivoAEditar;
        private bool ModoEdicao;
        public NovoMotivoForm(MainForm frm, bool modoEdicao = false, Motivo motivoAnterior = null)
        {
            InitializeComponent();
            mainForm = frm;
            context = frm.context;
            ModoEdicao = modoEdicao;
            if (ModoEdicao)
            {
                lblTitulo.Text = "Editar motivo";
                motivoAEditar = motivoAnterior;
                btnRegistrar.Text = "Editar";
            }
        }
        private void NovoMotivoForm_Load(object sender, EventArgs e)
        {
            if (ModoEdicao)
            {
                txtNomeDoMotivo.Text = motivoAEditar.Nome;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ModoEdicao)
            {
                EditarMotivo();
            }
            else if (ValidarNome())
            {
                CriarNovoMotivo();
                SimpleMessage.Inform("Motivo criado com sucesso");
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
            else if (!DbWorker.VerificarNomeDoMotivo(context, txtNomeDoMotivo.Text))
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
            DbWorker.CriarEntidade(context, novoMotivo);
        }
        private void EditarMotivo()
        {
            if (ValidarNome())
            {
                Motivo motivoEditado = new Motivo
                {
                    Nome = txtNomeDoMotivo.Text
                };
                DbWorker.EditarMotivo(context, motivoAEditar, motivoEditado);
            }
        }

        private void AtualizarGridMotivos()
        {
            mainForm.RefreshGrid(DbWorker.ListarTabelaMotivos(context));
        }
    }
}
