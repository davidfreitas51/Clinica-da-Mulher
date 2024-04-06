using ClinicaDaMulher.Controls;
using ClinicaDaMulher.Data;
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

namespace ClinicaDaMulher.Forms
{
    public partial class NovoClienteForm : Form
    {
        private readonly MainForm mainForm;
        public NovoClienteForm(MainForm frm)
        {
            InitializeComponent();

            mainForm = frm;
        }
        private bool VerificarValidadeDosCampos()
        {
            if (!DbWorker.VerificarCpfValido(mtxCpf.Text))
            {
                SimpleMessage.Error("Já existe um cliente com esse CPF");
                return false;
            }
            else if (mtxCpf.Text.Length != 14)
            {
                SimpleMessage.Error("Insira um CPF válido");
                return false;
            }
            return true;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (VerificarValidadeDosCampos())
            {
                List<string> novoCliente = new List<string>();
                novoCliente.Add(txtNome.Text);
                novoCliente.Add(mtxCpf.Text);
                novoCliente.Add(mtxTelefone.Text);
                DbWorker.CriarCliente(novoCliente);

                SimpleMessage.Inform("Cliente cadastrado com sucesso!");
                mainForm.RefreshGridCliente(DbWorker.ListarTabelaClientes());
                this.Close();
            }
        }

        private void NovoClienteForm_Load(object sender, EventArgs e)
        {
            List<string> unidadesFederativas = new List<string> {
                "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", 
                "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"  
            };
            cbxEstado.DataSource = unidadesFederativas;
            cbxEstado.Text = "";
        }
    }
}
