namespace ClinicaDaMulher.Controls
{
    partial class PainelRazoes
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            dgvRazoes = new DataGridView();
            clnNome = new DataGridViewTextBoxColumn();
            clnCPF = new DataGridViewTextBoxColumn();
            clmTelefone = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRazoes).BeginInit();
            SuspendLayout();
            // 
            // dgvRazoes
            // 
            dgvRazoes.AllowUserToAddRows = false;
            dgvRazoes.AllowUserToDeleteRows = false;
            dgvRazoes.AllowUserToOrderColumns = true;
            dgvRazoes.AllowUserToResizeColumns = false;
            dgvRazoes.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dgvRazoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvRazoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRazoes.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.Info;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvRazoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvRazoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRazoes.Columns.AddRange(new DataGridViewColumn[] { clnNome, clnCPF, clmTelefone });
            dgvRazoes.Dock = DockStyle.Fill;
            dgvRazoes.EnableHeadersVisualStyles = false;
            dgvRazoes.GridColor = Color.Black;
            dgvRazoes.Location = new Point(0, 0);
            dgvRazoes.Name = "dgvRazoes";
            dgvRazoes.ReadOnly = true;
            dgvRazoes.RowHeadersVisible = false;
            dgvRazoes.RowHeadersWidth = 51;
            dgvRazoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRazoes.Size = new Size(447, 583);
            dgvRazoes.TabIndex = 3;
            dgvRazoes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // clnNome
            // 
            clnNome.DataPropertyName = "Nome";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clnNome.DefaultCellStyle = dataGridViewCellStyle8;
            clnNome.HeaderText = "Nome";
            clnNome.MinimumWidth = 6;
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 87;
            // 
            // clnCPF
            // 
            clnCPF.DataPropertyName = "CPF";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clnCPF.DefaultCellStyle = dataGridViewCellStyle9;
            clnCPF.HeaderText = "CPF";
            clnCPF.MinimumWidth = 6;
            clnCPF.Name = "clnCPF";
            clnCPF.ReadOnly = true;
            clnCPF.Width = 69;
            // 
            // clmTelefone
            // 
            clmTelefone.DataPropertyName = "Telefone";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmTelefone.DefaultCellStyle = dataGridViewCellStyle10;
            clmTelefone.HeaderText = "Telefone";
            clmTelefone.MinimumWidth = 6;
            clmTelefone.Name = "clmTelefone";
            clmTelefone.ReadOnly = true;
            clmTelefone.Width = 106;
            // 
            // PainelRazoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvRazoes);
            Name = "PainelRazoes";
            Size = new Size(447, 583);
            ((System.ComponentModel.ISupportInitialize)dgvRazoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvRazoes;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCPF;
        private DataGridViewTextBoxColumn clmTelefone;
    }
}
