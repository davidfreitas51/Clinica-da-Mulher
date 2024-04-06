using ClinicaDaMulher.Data;
using ClinicaDaMulher.Models;
using MessageUtils;
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
    public partial class PainelClientes : UserControl
    {
        private readonly MainForm mainForm;
        public PainelClientes(MainForm frm, List<Cliente> clientes)
        {
            InitializeComponent();
            mainForm = frm;
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = clientes;
        }
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
