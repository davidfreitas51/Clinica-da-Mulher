using ClinicaDaMulher.Data;
using ClinicaDaMulher.Models;
using Maroquio;
using MessageUtils;

namespace ClinicaDaMulher.Controls
{
    public partial class PainelConsultas : UserControl
    {
        private readonly MainForm mainForm;
        private readonly IClinicaDaMulherContext context;
        public PainelConsultas(MainForm frm, SortableBindingList<Consulta> consultas)
        {
            InitializeComponent();
            mainForm = frm;
            context = mainForm.context;
            dgvConsultas.AutoGenerateColumns = false;
            dgvConsultas.DataSource = consultas;
        }

        private void dgvConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvConsultas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void DeletarConsulta()
        {
            var consultaSelecionada = ObterConsultaSelecionada();
            if (consultaSelecionada != null)
            {

                if (SimpleMessage.Confirm($"Deseja mesmo excluir a consulta selecionada?"))
                {
                    DbWorker.DeletarConsulta(context, consultaSelecionada.Id);
                    SimpleMessage.Inform("Consulta deletada com sucesso!");
                    mainForm.RefreshGrid(DbWorker.ListarTabelaConsultas(context));
                }
            }
        }
        private Motivo ObterConsultaSelecionada()
        {
            if (ChecarSelecaoDeLinha())
            {
                int indiceLinha = dgvConsultas.SelectedRows[0].Index;
                string idMotivo = dgvConsultas.Rows[indiceLinha].Cells["clnId"].Value.ToString();
                return new Motivo
                {
                    Id = int.Parse(idMotivo),
                    Nome = dgvConsultas.Rows[indiceLinha].Cells["clnMotivo"].Value.ToString(),
                };
            }
            return null;
        }
        public bool ChecarSelecaoDeLinha()
        {
            if (dgvConsultas.SelectedRows.Count > 0)
            {
                return true;
            }
            SimpleMessage.Error("Selecione uma consulta do painel");
            return false;
        }
    }
}