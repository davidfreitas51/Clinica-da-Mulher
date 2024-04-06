using ClinicaDaMulher.Controls;
using ClinicaDaMulher.Data;
using ClinicaDaMulher.Forms;
using Microsoft.EntityFrameworkCore;

namespace ClinicaDaMulher
{
    public partial class MainForm : Form
    {
        bool viewCollapsed = false;
        bool clientCollapsed = false;
        bool reasonsCollapsed = false;
        public MainForm()
        {
            InitializeComponent();
        }

        public void CollapsePanel(Panel panel, ref bool collapsed)
        {
            if (collapsed)
            {
                panel.Height += 11;
                PanelStopGrowing(panel);
            }
            else
            {
                panel.Height -= 11;
                PanelStopShrinking(panel);
            }
        }
        public void PanelStopGrowing(Panel panel)
        {
            if (panel.Size == panel.MaximumSize)
            {
                timerVer.Stop();
                panel.Size = panel.MaximumSize;
            }
        }
        public void PanelStopShrinking(Panel panel)
        {
            if (panel.Size == panel.MinimumSize)
            {
                timerVer.Stop();
                panel.Size = panel.MinimumSize;
            }
        }
        public void MudarPainelSuperior(Control controle)
        {
            this.pnlUpperControls.Controls.Clear();
            controle.Dock = DockStyle.Fill;
            this.pnlUpperControls.Controls.Add(controle);
        }
        private void btnVer_Click(object sender, EventArgs e)
        {
            viewCollapsed = !viewCollapsed;
            timerView.Start();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            clientCollapsed = !clientCollapsed;
            timerClientes.Start();
        }
        private void btnRazoes_Click(object sender, EventArgs e)
        {
            reasonsCollapsed = !reasonsCollapsed;
            timerRazoes.Start();
        }
        private void timerClientes_Tick(object sender, EventArgs e)
        {
            CollapsePanel(pnlClientes, ref clientCollapsed);
        }

        private void timerRazoes_Tick(object sender, EventArgs e)
        {
            CollapsePanel(pnlRazoes, ref reasonsCollapsed);
        }

        private void timerView_Tick(object sender, EventArgs e)
        {
            CollapsePanel(pnlVer, ref viewCollapsed);
        }

        private void btnVerConsultas_Click(object sender, EventArgs e)
        {
            VerConsultas verConsultas = new VerConsultas();
            MudarPainelSuperior(verConsultas);
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            VerClientes verClientes = new VerClientes();
            MudarPainelSuperior(verClientes);
            dgvPrincipal.DataSource = DbWorker.ListarTabelaClientes();
        }

        private void btnVerRazões_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            NovoClienteForm novoClienteForm = new NovoClienteForm();
            novoClienteForm.ShowDialog();
        }

        private void dgvPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPrincipal_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
