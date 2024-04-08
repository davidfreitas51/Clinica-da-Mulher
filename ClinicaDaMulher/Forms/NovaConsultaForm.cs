using ClinicaDaMulher.Data;
using ClinicaDaMulher.Models;
using MessageUtils;

namespace ClinicaDaMulher.Forms
{
    public partial class NovaConsultaForm : Form
    {
        public readonly MainForm mainForm;
        public NovaConsultaForm(MainForm frm)
        {
            mainForm = frm;
            InitializeComponent();
        }

        private void NovaConsultaForm_Load(object sender, EventArgs e)
        {
            cbxMotivo.DataSource = DbWorker.ListarMotivos();
            cbxMotivo.Text = "";
        }
        private bool ValidarCampos()
        {
            string cpfNumerico = new string(mtxCpf.Text.Where(char.IsDigit).ToArray());
            string mensagemDeErro = "";
            if (DbWorker.VerificarCpfValido(mtxCpf.Text))
            {
                mensagemDeErro = "CPF não cadastrado";
            }
            if (cpfNumerico.Length != 11)
            {
                mensagemDeErro = "Digite um CPF válido";
            }
            if (!DbWorker.VerificarExistenciaDeMotivo(cbxMotivo.Text))
            {
                mensagemDeErro = "Escolha um motivo da lista";
            }
            if (mtxData.Text.Length != 10)
            {
                mensagemDeErro = "Digite uma data válida";
            }
            if (mtxHorario.Text.Length != 5)
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
            if (mtxCpf.Text != null && mtxCpf.Text.Trim().Replace(".", "").Replace("-", "").Length > 6)
            {
                return true;
            }
            if (cbxMotivo != null & cbxMotivo.Text.Length > 0)
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string nomeDaCliente = DbWorker.NomePeloCPF(mtxCpf.Text);
                string mensagemDeConfirmação = $"Confirme os dados:\n\nCliente: {nomeDaCliente}\nCPF: {mtxCpf.Text}\n" +
                $"Dia: {mtxData.Text}\nHorário: {mtxHorario.Text}\nMotivo: {cbxMotivo.Text}\n\nEstá tudo correto?";
                if (SimpleMessage.Confirm(mensagemDeConfirmação))
                {
                    Consulta novaConsulta = new Consulta
                    {
                        Cliente = nomeDaCliente,
                        CPF = mtxCpf.Text,
                        Data = mtxData.Text,
                        Hora = mtxHorario.Text,
                        Motivo = cbxMotivo.Text.Trim(),
                    };
                    SimpleMessage.Inform($"Data = {mtxData.Text.Length}\nHora = {mtxHorario.Text.Length}");
                    DbWorker.CriarConsulta(novaConsulta);
                    SimpleMessage.Inform("Consulta criada com sucesso");
                    var consultas = DbWorker.ListarTabelaConsultas();
                    mainForm.RefreshGridConsultas(DbWorker.ListarTabelaConsultas());
                    this.Close();
                }
            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (VerificarPreenchimentoDosCampos())
            {
                if(SimpleMessage.Confirm("Você tem mudanças não salvas, deseja mesmo sair?"))
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
