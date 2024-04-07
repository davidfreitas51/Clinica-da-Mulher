using ClinicaDaMulher.Controls;
using ClinicaDaMulher.Data;
using ClinicaDaMulher.Models;
using Maroquio;
using MessageUtils;

namespace ClinicaDaMulher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void MudarPainelSuperior(Control controle)
        {
            this.pnlUpperControls.Controls.Clear();
            controle.Dock = DockStyle.Fill;
            this.pnlUpperControls.Controls.Add(controle);
        }
        private void btnVerConsultas_Click_1(object sender, EventArgs e)
        {
            VerConsultas verConsultas = new VerConsultas(this);
            MudarPainelSuperior(verConsultas);
            try
            {
                RefreshGridConsultas(DbWorker.ListarTabelaConsultas());
            }
            catch (Exception ex)
            {
                SimpleMessage.Inform(ex.ToString());
            }
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            VerClientes verClientes = new VerClientes(this);
            MudarPainelSuperior(verClientes);
            RefreshGridCliente(DbWorker.ListarTabelaClientes());
        }
        private void btnVerRazões_Click(object sender, EventArgs e)
        {
            VerMotivos verMotivos = new VerMotivos(this);
            MudarPainelSuperior(verMotivos);
            RefreshGridMotivos(DbWorker.ListarTabelaMotivos());
        }
        public void RefreshGridConsultas(SortableBindingList<Consulta> consultas)
        {
            this.painelDgv.Controls.Clear();
            PainelConsultas painelConsultas = new PainelConsultas(this, consultas);
            painelConsultas.Dock = DockStyle.Fill;
            this.painelDgv.Controls.Add(painelConsultas);
        }
        public void RefreshGridCliente(SortableBindingList<Cliente> clientes)
        {
            this.painelDgv.Controls.Clear();
            PainelClientes painelClientes = new PainelClientes(this, clientes);
            painelClientes.Dock = DockStyle.Fill;
            this.painelDgv.Controls.Add(painelClientes);
        }
        public void RefreshGridMotivos(SortableBindingList<Motivo> motivos)
        {
            this.painelDgv.Controls.Clear();
            PainelMotivos painelMotivos = new PainelMotivos(this, motivos);
            painelMotivos.Dock = DockStyle.Fill;
            this.painelDgv.Controls.Add(painelMotivos);
        }
    }
}
