using MessageUtils;

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
    }
}
