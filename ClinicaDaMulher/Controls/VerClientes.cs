﻿using ClinicaDaMulher.Data;
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
    public partial class VerClientes : UserControl
    {
        private readonly MainForm mainForm;
        public VerClientes(MainForm frm)
        {
            InitializeComponent();
            mainForm = frm;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            mainForm.RefreshGridCliente(DbWorker.ListarTabelaClientes(txtNome.Text.Trim(), txtCpf.Text.Trim()));
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mainForm.RefreshGridCliente(DbWorker.ListarTabelaClientes(txtNome.Text.Trim(), txtCpf.Text.Trim()));
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mainForm.RefreshGridCliente(DbWorker.ListarTabelaClientes(txtNome.Text.Trim(), txtCpf.Text.Trim()));
            }
        }
    }
}
