namespace ClinicaDaMulher
{
    public partial class MainForm : Form
    {
        bool ClientCollapsed = false;
        bool viewCollapsed = false;
        bool reasonsCollapsed = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void timerClientes_Tick(object sender, EventArgs e)
        {
            if (ClientCollapsed)
            {
                pnlClientes.Size = new Size(pnlClientes.Size.Width, pnlClientes.Size.Height + 11);
                if (pnlClientes.Size.Height >= 275)
                {
                    timerClientes.Stop();
                    pnlClientes.Size = new Size(pnlClientes.Size.Width, 275);
                }
            }
            else
            {
                pnlClientes.Size = new Size(pnlClientes.Size.Width, pnlClientes.Size.Height - 11);
                if (pnlClientes.Size.Height <= 70)
                {
                    timerClientes.Stop();
                    pnlClientes.Size = new Size(pnlClientes.Size.Width, 70);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ClientCollapsed = !ClientCollapsed;
            timerClientes.Start();
        }
    }
}
