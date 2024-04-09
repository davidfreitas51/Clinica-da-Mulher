using ClinicaDaMulher.Controls;
using ClinicaDaMulher.Data;
using ClinicaDaMulher.Models;
using Maroquio;

namespace ClinicaDaMulher
{
    public partial class MainForm : Form
    {
        public readonly IClinicaDaMulherContext context;
        public MainForm()
        {
            InitializeComponent();
            context = new ClinicaDaMulherContext();
        }
        private void btnVerConsultas_Click_1(object sender, EventArgs e)
        {
            VerConsultas verConsultas = new VerConsultas(this);
            MudarPainelSuperior(verConsultas);

            RefreshGrid(DbWorker.ListarTabelaConsultas(context));
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            VerClientes verClientes = new VerClientes(this);
            MudarPainelSuperior(verClientes);

            RefreshGrid(DbWorker.ListarTabelaClientes(context));
        }
        private void btnVerMotivos_Click(object sender, EventArgs e)
        {
            VerMotivos verMotivos = new VerMotivos(this);
            MudarPainelSuperior(verMotivos);
            RefreshGrid(DbWorker.ListarTabelaMotivos(context));
        }
        public void MudarPainelSuperior(Control controle)
        {
            this.pnlUpperControls.Controls.Clear();
            controle.Dock = DockStyle.Fill;
            this.pnlUpperControls.Controls.Add(controle);
        }
        public void RefreshGrid<T>(SortableBindingList<T> dados)
        {
            this.painelDgv.Controls.Clear();
            UserControl panel = HandleType(typeof(T), dados);

            panel.Dock = DockStyle.Fill;
            this.painelDgv.Controls.Add(panel);
        }
        public UserControl HandleType<T>(Type type, SortableBindingList<T> dados)
        {
            UserControl panel = null;
            switch (type.Name)
            {
                case nameof(Consulta):
                    panel = new PainelConsultas(this, dados as SortableBindingList<Consulta>);
                    break;
                case nameof(Cliente):
                    panel = new PainelClientes(this, dados as SortableBindingList<Cliente>);
                    break;
                case nameof(Motivo):
                    panel = new PainelMotivos(this, dados as SortableBindingList<Motivo>);
                    break;
            }
            return panel;
        }
    }
}
