using ClinicaDaMulher.Controls;
using ClinicaDaMulher.Data;
using ClinicaDaMulher.Models;
using Maroquio;
using MessageUtils;

namespace ClinicaDaMulher
{
    public partial class MainForm : Form
    {
        public readonly IClinicaDaMulherContext context;
        public static PainelConsultas painelDeConsultas;
        public static PainelClientes painelDeClientes;
        public static PainelMotivos paineldeMotivos;
        public Button botaoColorido;
        public MainForm()
        {
            InitializeComponent();
            context = new ClinicaDaMulherContext();
        }
        private void btnVerConsultas_Click_1(object sender, EventArgs e)
        {
            VerConsultas verConsultas = new VerConsultas(this);
            MudarPainelSuperior(verConsultas);
            MudarCorDoBotaoSelecionado(btnVerConsultas);
            RefreshGrid(DbWorker.ListarTabelaConsultas(context));
        }
        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            VerClientes verClientes = new VerClientes(this);
            MudarPainelSuperior(verClientes);
            MudarCorDoBotaoSelecionado(btnVerClientes);
            RefreshGrid(DbWorker.ListarTabelaClientes(context));
        }
        private void btnVerMotivos_Click(object sender, EventArgs e)
        {
            VerMotivos verMotivos = new VerMotivos(this);
            MudarPainelSuperior(verMotivos);
            MudarCorDoBotaoSelecionado(btnVerMotivos);
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
            UserControl panel = HandleTypeControls(typeof(T), dados);

            panel.Dock = DockStyle.Fill;
            this.painelDgv.Controls.Add(panel);
        }
        public void ExcluirDados(Type type)
        {
            HandleTypeData(type);
        }
        public UserControl HandleTypeControls<T>(Type type, SortableBindingList<T> dados)
        {
            UserControl panel = null;
            switch (type.Name)
            {
                case nameof(Consulta):
                    panel = new PainelConsultas(this, dados as SortableBindingList<Consulta>);
                    painelDeConsultas = panel as PainelConsultas;
                    break;
                case nameof(Cliente):
                    panel = new PainelClientes(this, dados as SortableBindingList<Cliente>);
                    painelDeClientes = panel as PainelClientes;
                    break;
                case nameof(Motivo):
                    panel = new PainelMotivos(this, dados as SortableBindingList<Motivo>);
                    paineldeMotivos = panel as PainelMotivos;
                    break;
            }
            return panel;
        }
        public void HandleTypeData(Type type)
        {
            switch (type.Name)
            {
                case nameof(Consulta):
                    painelDeConsultas.DeletarConsulta();
                    break;
                case nameof(Cliente):
                    painelDeClientes.DeletarCliente();
                    break;
                case nameof(Motivo):
                    paineldeMotivos.DeletarMotivo();
                    break;
            }
        }
        public void MudarCorDoBotaoSelecionado(Button botao)
        {
            if (botaoColorido != null)
            {
                botaoColorido.BackColor = Color.FromArgb(55, 40, 83);
            }
            botaoColorido = botao;
            botaoColorido.BackColor = Color.FromArgb(75, 54, 113);
        }
        private void MudarCorDoBotaoMousePorCima(Button botao)
        {
            if (botaoColorido != null && botaoColorido != botao)
            {
                if (botao.BackColor == Color.FromArgb(55, 40, 83))
                {
                    botao.BackColor = Color.FromArgb(56, 41, 84);
                }
                else
                {
                    botao.BackColor = Color.FromArgb(55, 40, 83);
                }
            }
        }
        private void btnVerConsultas_MouseEnter(object sender, EventArgs e)
        {
            MudarCorDoBotaoMousePorCima(btnVerConsultas);
        }

        private void btnVerConsultas_MouseLeave(object sender, EventArgs e)
        {
            MudarCorDoBotaoMousePorCima(btnVerConsultas);
        }

        private void btnVerClientes_MouseEnter(object sender, EventArgs e)
        {
            MudarCorDoBotaoMousePorCima(btnVerClientes);
        }

        private void btnVerClientes_MouseLeave(object sender, EventArgs e)
        {
            MudarCorDoBotaoMousePorCima(btnVerClientes);
        }

        private void btnVerMotivos_MouseEnter(object sender, EventArgs e)
        {
            MudarCorDoBotaoMousePorCima(btnVerMotivos);
        }

        private void btnVerMotivos_MouseLeave(object sender, EventArgs e)
        {
            MudarCorDoBotaoMousePorCima(btnVerMotivos);
        }
    }
}
