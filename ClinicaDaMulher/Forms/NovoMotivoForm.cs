using ClinicaDaMulher.Data;
using ClinicaDaMulher.Models;
using MessageUtils;
using System.Globalization;

namespace ClinicaDaMulher.Forms
{
    public partial class NovoMotivoForm : Form
    {
        private readonly MainForm mainForm;
        public NovoMotivoForm(MainForm frm)
        {
            InitializeComponent();
            mainForm = frm;
        }

        private void NovoMotivoForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNomeDoMotivo != null && !string.IsNullOrEmpty(txtNomeDoMotivo.Text))
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarNome())
            {
                Motivo novoMotivo = new Motivo();
                novoMotivo.Nome = txtNomeDoMotivo.Text;
                DbWorker.CriarMotivo(novoMotivo);
                SimpleMessage.Inform("Motivo criado com sucesso!");
                mainForm.RefreshGridMotivos(DbWorker.ListarTabelaMotivos());
                this.Close();
            }
            else
            {
                SimpleMessage.Inform("Um motivo com o mesmo nome já existe");
            }
        }
        private bool ValidarNome()
        {
            if (txtNomeDoMotivo != null && !string.IsNullOrEmpty(txtNomeDoMotivo.Text))
            {
                if (DbWorker.ValidarNomeDoMotivo(txtNomeDoMotivo.Text))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
