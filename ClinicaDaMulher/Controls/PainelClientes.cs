using ClinicaDaMulher.Data;
using ClinicaDaMulher.Models;
using Maroquio;
using MessageUtils;

namespace ClinicaDaMulher.Controls
{
    public partial class PainelClientes : UserControl
    {
        private readonly MainForm mainForm;
        private readonly IClinicaDaMulherContext context;
        public PainelClientes(MainForm frm, SortableBindingList<Cliente> clientes)
        {
            InitializeComponent();
            mainForm = frm;
            context = mainForm.context;
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = clientes;
        }
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void DeletarCliente()
        {
            var clienteSelecionado = ObterClienteSelecionado();
            if (clienteSelecionado != null)
            {

                if (SimpleMessage.Confirm($"Deseja mesmo excluir o cliente {clienteSelecionado.Nome}?"))
                {
                    if (DbWorker.BuscarConsultasPendentes(context, clienteSelecionado.CPF))
                    {
                        SimpleMessage.Error("Esse cliente ainda tem consultas. Desmarque-as primeiro");
                    }
                    else
                    {
                        DbWorker.DeletarCliente(context, clienteSelecionado.Id);
                        SimpleMessage.Inform("Cliente deletado com sucesso!");
                        mainForm.RefreshGrid(DbWorker.ListarTabelaClientes(context));
                    }
                }
            }
        }
        private Cliente ObterClienteSelecionado()
        {
            if (ChecarSelecaoDeLinha())
            {
                int indiceLinha = dgvClientes.SelectedRows[0].Index;
                string idCliente = dgvClientes.Rows[indiceLinha].Cells["clnId"].Value.ToString();
                return new Cliente
                {
                    Id = int.Parse(idCliente),
                    Nome = dgvClientes.Rows[indiceLinha].Cells["clnNome"].Value.ToString(),
                    CPF = dgvClientes.Rows[indiceLinha].Cells["clnCPF"].Value.ToString()
                };
            }
            return null;
        }
        public bool ChecarSelecaoDeLinha()
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                return true;
            }
            SimpleMessage.Error("Selecione um cliente do painel");
            return false;
        }

    }
}
