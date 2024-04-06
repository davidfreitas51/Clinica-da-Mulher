namespace ClinicaDaMulher.Controls
{
    partial class PainelClientes
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvClientes = new DataGridView();
            clnNome = new DataGridViewTextBoxColumn();
            clnCPF = new DataGridViewTextBoxColumn();
            clmTelefone = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToOrderColumns = true;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClientes.BackgroundColor = SystemColors.ControlDarkDark;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clnNome, clnCPF, clmTelefone });
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.GridColor = Color.Black;
            dgvClientes.Location = new Point(0, 0);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(841, 860);
            dgvClientes.TabIndex = 2;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick_1;
            // 
            // clnNome
            // 
            clnNome.DataPropertyName = "Nome";
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clnNome.DefaultCellStyle = dataGridViewCellStyle2;
            clnNome.HeaderText = "Nome";
            clnNome.MinimumWidth = 6;
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 79;
            // 
            // clnCPF
            // 
            clnCPF.DataPropertyName = "CPF";
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clnCPF.DefaultCellStyle = dataGridViewCellStyle3;
            clnCPF.HeaderText = "CPF";
            clnCPF.MinimumWidth = 6;
            clnCPF.Name = "clnCPF";
            clnCPF.ReadOnly = true;
            clnCPF.Width = 62;
            // 
            // clmTelefone
            // 
            clmTelefone.DataPropertyName = "Telefone";
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmTelefone.DefaultCellStyle = dataGridViewCellStyle4;
            clmTelefone.HeaderText = "Telefone";
            clmTelefone.MinimumWidth = 6;
            clmTelefone.Name = "clmTelefone";
            clmTelefone.ReadOnly = true;
            clmTelefone.Width = 95;
            // 
            // PainelClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvClientes);
            Name = "PainelClientes";
            Size = new Size(841, 860);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvClientes;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCPF;
        private DataGridViewTextBoxColumn clmTelefone;
    }
}
