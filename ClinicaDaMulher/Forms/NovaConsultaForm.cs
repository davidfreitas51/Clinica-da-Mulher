using ClinicaDaMulher.Data;
using ClinicaDaMulher.Models;
using MessageUtils;
using System.Text.RegularExpressions;

namespace ClinicaDaMulher.Forms
{
    public partial class NovaConsultaForm : Form
    {
        private readonly MainForm mainForm;
        private readonly IClinicaDaMulherContext context;
        public NovaConsultaForm(MainForm frm)
        {
            InitializeComponent();
            mainForm = frm;
            context = frm.context;
        }
        private void NovaConsultaForm_Load(object sender, EventArgs e)
        {
            cbxMotivo.DataSource = DbWorker.ListarMotivos(context);
            cbxMotivo.Text = "";
        }
        private void btnMarcar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() && ConfirmarDados())
            {
                CriarNovaConsulta();
                SimpleMessage.Inform("Consulta criada com sucesso");
                var consultas = DbWorker.ListarTabelaConsultas(context);
                mainForm.RefreshGrid(DbWorker.ListarTabelaConsultas(context));
                this.Close();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (VerificarAlteracoesNaoSalvas())
            {
                this.Close();
            }
        }
        private bool ValidarCampos()
        {
            string mensagemDeErro = "";
            if (DbWorker.VerificarCpfValido(context, mtxCpf.Text))
            {
                mensagemDeErro = "CPF não cadastrado";
            }
            if (RemoverLiterais(mtxCpf.Text).Length != 11)
            {
                mensagemDeErro = "Digite um CPF válido";
            }
            if (!DbWorker.VerificarExistenciaDeMotivo(context, cbxMotivo.Text))
            {
                mensagemDeErro = "Escolha um motivo da lista";
            }
            if (RemoverLiterais(mtxData.Text).Length != 8)
            {
                mensagemDeErro = "Digite uma data válida";
            }
            if (RemoverLiterais(mtxHorario.Text).Length != 4)
            {
                mensagemDeErro = "Digite um horário válido";
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
            if (RemoverLiterais(mtxCpf.Text).Length > 0)
            {
                return false;
            }
            if (RemoverLiterais(cbxMotivo.Text).Length > 0)
            {
                return false;
            }
            if (RemoverLiterais(mtxData.Text).Length > 0)
            {
                return false;
            }
            if (RemoverLiterais(mtxHorario.Text).Length > 0)
            {
                return false;
            }
            return true;
        }
        private bool ConfirmarDados()
        {
            string nomeDaCliente = DbWorker.NomePeloCPF(context, mtxCpf.Text);
            string mensagemDeConfirmação = $"Confirme os dados:\n\nCliente: {nomeDaCliente}\nCPF: {mtxCpf.Text}\n" +
            $"Dia: {mtxData.Text}\nHorário: {mtxHorario.Text}\nMotivo: {cbxMotivo.Text}\n\nEstá tudo correto?";
            return SimpleMessage.Confirm(mensagemDeConfirmação);
        }
        private void CriarNovaConsulta()
        {
            Consulta novaConsulta = new Consulta
            {
                Cliente = DbWorker.NomePeloCPF(context, mtxCpf.Text),
                CPF = mtxCpf.Text,
                Data = mtxData.Text,
                Hora = mtxHorario.Text,
                Motivo = cbxMotivo.Text.Trim(),
            };
            DbWorker.CriarConsulta(context, novaConsulta);
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
        public static string RemoverLiterais(string input)
        {
            return Regex.Replace(input, @"[^\d]", "");
        }
    }
}