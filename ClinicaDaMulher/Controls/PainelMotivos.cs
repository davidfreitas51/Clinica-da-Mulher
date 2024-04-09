using ClinicaDaMulher.Data;
using ClinicaDaMulher.Models;
using Maroquio;
using MessageUtils;

namespace ClinicaDaMulher.Controls
{
    public partial class PainelMotivos : UserControl
    {
        private readonly MainForm mainForm;
        private readonly IClinicaDaMulherContext context;
        public PainelMotivos(MainForm frm, SortableBindingList<Motivo> razoes)
        {
            InitializeComponent();
            mainForm = frm;
            context = mainForm.context;
            dgvMotivos.AutoGenerateColumns = false;
            dgvMotivos.DataSource = razoes;
        }
        public void DeletarMotivo()
        {
            var motivoSelecionado = ObterMotivoSelecionado();
            if (motivoSelecionado != null)
            {

                if (SimpleMessage.Confirm($"Deseja mesmo excluir o motivo {motivoSelecionado.Nome}?"))
                {
                    if (DbWorker.BuscarMotivosDeConsultas(context, motivoSelecionado.Nome))
                    {
                        SimpleMessage.Error("Ainda há consultas com esse motivo. Desmarque-as primeiro");
                    }
                    else
                    {
                        DbWorker.DeletarMotivo(context, motivoSelecionado.Id);
                        SimpleMessage.Inform("Motivo deletado com sucesso!");
                        mainForm.RefreshGrid(DbWorker.ListarTabelaMotivos(context));
                    }
                }
            }
        }
        private Motivo ObterMotivoSelecionado()
        {
            if (ChecarSelecaoDeLinha())
            {
                int indiceLinha = dgvMotivos.SelectedRows[0].Index;
                string idMotivo = dgvMotivos.Rows[indiceLinha].Cells["clnId"].Value.ToString();
                return new Motivo
                {
                    Id = int.Parse(idMotivo),
                    Nome = dgvMotivos.Rows[indiceLinha].Cells["clnMotivo"].Value.ToString(),
                };
            }
            return null;
        }
        public bool ChecarSelecaoDeLinha()
        {
            if (dgvMotivos.SelectedRows.Count > 0)
            {
                return true;
            }
            SimpleMessage.Error("Selecione um motivo do painel");
            return false;
        }

        private void dgvMotivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
