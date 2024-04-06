using ClinicaDaMulher.Controls;
using ClinicaDaMulher.Data;
using ClinicaDaMulher.Models;
using Maroquio;

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
            RefreshGridConsultas(DbWorker.ListarTabelaConsultas());
        }
        public void RefreshGridConsultas(SortableBindingList<Consulta> consultas)
        {
            this.painelDgv.Controls.Clear();
            PainelConsultas painelConsultas = new PainelConsultas(this, consultas);
            painelConsultas.Dock = DockStyle.Fill;
            this.painelDgv.Controls.Add(painelConsultas);
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            VerClientes verClientes = new VerClientes(this);
            MudarPainelSuperior(verClientes);
            RefreshGridCliente(DbWorker.ListarTabelaClientes());
        }
        public void RefreshGridCliente(SortableBindingList<Cliente> clientes)
        {
            this.painelDgv.Controls.Clear();
            PainelClientes painelClientes = new PainelClientes(this, clientes);
            painelClientes.Dock = DockStyle.Fill;
            this.painelDgv.Controls.Add(painelClientes);
        }
        private void btnVerRaz�es_Click(object sender, EventArgs e)
        {
            VerMotivos verMotivos = new VerMotivos(this);
            MudarPainelSuperior(verMotivos);
            RefreshGridMotivos(DbWorker.ListarTabelaMotivos());
        }
        public void RefreshGridMotivos(SortableBindingList<Motivo> motivos)
        {
            this.painelDgv.Controls.Clear();
            PainelRazoes painelMotivos = new PainelRazoes(this, motivos);
            painelMotivos.Dock = DockStyle.Fill;
            this.painelDgv.Controls.Add(painelMotivos);
        }
    }
}
