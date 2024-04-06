using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaDaMulher.Forms
{
    public partial class NovaConsultaForm : Form
    {
        public readonly MainForm mainForm;
        public NovaConsultaForm(MainForm frm)
        {
            mainForm = frm;
            InitializeComponent();
        }

        private void NovaConsultaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
