using ClinicaDaMulher.Data;
using ClinicaDaMulher.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaDaMulher.Controls
{
    public partial class VerMotivos : UserControl
    {
        public readonly MainForm mainForm;
        public VerMotivos(MainForm frm)
        {
            InitializeComponent();
            mainForm = frm;
        }

        private void btnNovaRazao_Click(object sender, EventArgs e)
        {
            NovoMotivoForm novoMotivo = new NovoMotivoForm(mainForm);
            novoMotivo.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mainForm.RefreshGridMotivos(DbWorker.ListarTabelaMotivos(txtMotivo.Text.Trim()));
        }
    }
}
