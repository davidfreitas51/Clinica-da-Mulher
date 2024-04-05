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
                if (panel.Size == panel.MaximumSize)
                {
                    timerVer.Stop();
                    panel.Size = panel.MaximumSize;
                }
            }
            else
            {
                panel.Height -= 11;
                if (panel.Size == panel.MinimumSize)
                {
                    timerVer.Stop();
                    panel.Size = panel.MinimumSize;
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            viewCollapsed = !viewCollapsed;
            timerView.Start();
        }
        private void button12_Click(object sender, EventArgs e)
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
    }
}
