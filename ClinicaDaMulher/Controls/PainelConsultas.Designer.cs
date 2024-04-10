namespace ClinicaDaMulher.Controls
{
    partial class PainelConsultas
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dgvConsultas = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNomeDoCliente = new DataGridViewTextBoxColumn();
            clnCPFdoCliente = new DataGridViewTextBoxColumn();
            clnData = new DataGridViewTextBoxColumn();
            clnHorario = new DataGridViewTextBoxColumn();
            clnMotivo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
            SuspendLayout();
            // 
            // dgvConsultas
            // 
            dgvConsultas.AllowUserToAddRows = false;
            dgvConsultas.AllowUserToDeleteRows = false;
            dgvConsultas.AllowUserToOrderColumns = true;
            dgvConsultas.AllowUserToResizeColumns = false;
            dgvConsultas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvConsultas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultas.BackgroundColor = Color.FromArgb(36, 26, 55);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(137, 31, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultas.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNomeDoCliente, clnCPFdoCliente, clnData, clnHorario, clnMotivo });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvConsultas.DefaultCellStyle = dataGridViewCellStyle9;
            dgvConsultas.Dock = DockStyle.Fill;
            dgvConsultas.EnableHeadersVisualStyles = false;
            dgvConsultas.GridColor = Color.FromArgb(109, 25, 88);
            dgvConsultas.Location = new Point(0, 0);
            dgvConsultas.Name = "dgvConsultas";
            dgvConsultas.ReadOnly = true;
            dgvConsultas.RowHeadersVisible = false;
            dgvConsultas.RowHeadersWidth = 51;
            dgvConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultas.Size = new Size(555, 574);
            dgvConsultas.TabIndex = 4;
            dgvConsultas.CellContentClick += dgvConsultas_CellContentClick_1;
            // 
            // clnId
            // 
            clnId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            clnId.DataPropertyName = "Id";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clnId.DefaultCellStyle = dataGridViewCellStyle3;
            clnId.HeaderText = "ID";
            clnId.MinimumWidth = 6;
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 125;
            // 
            // clnNomeDoCliente
            // 
            clnNomeDoCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clnNomeDoCliente.DataPropertyName = "Cliente";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clnNomeDoCliente.DefaultCellStyle = dataGridViewCellStyle4;
            clnNomeDoCliente.HeaderText = "Cliente";
            clnNomeDoCliente.MinimumWidth = 6;
            clnNomeDoCliente.Name = "clnNomeDoCliente";
            clnNomeDoCliente.ReadOnly = true;
            // 
            // clnCPFdoCliente
            // 
            clnCPFdoCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clnCPFdoCliente.DataPropertyName = "CPF";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clnCPFdoCliente.DefaultCellStyle = dataGridViewCellStyle5;
            clnCPFdoCliente.HeaderText = "CPF";
            clnCPFdoCliente.MinimumWidth = 6;
            clnCPFdoCliente.Name = "clnCPFdoCliente";
            clnCPFdoCliente.ReadOnly = true;
            // 
            // clnData
            // 
            clnData.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clnData.DataPropertyName = "Data";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clnData.DefaultCellStyle = dataGridViewCellStyle6;
            clnData.HeaderText = "Data";
            clnData.MinimumWidth = 6;
            clnData.Name = "clnData";
            clnData.ReadOnly = true;
            // 
            // clnHorario
            // 
            clnHorario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clnHorario.DataPropertyName = "Hora";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 10.2F);
            clnHorario.DefaultCellStyle = dataGridViewCellStyle7;
            clnHorario.HeaderText = "Horário";
            clnHorario.MinimumWidth = 6;
            clnHorario.Name = "clnHorario";
            clnHorario.ReadOnly = true;
            // 
            // clnMotivo
            // 
            clnMotivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clnMotivo.DataPropertyName = "Motivo";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 10.2F);
            clnMotivo.DefaultCellStyle = dataGridViewCellStyle8;
            clnMotivo.HeaderText = "Motivo";
            clnMotivo.MinimumWidth = 6;
            clnMotivo.Name = "clnMotivo";
            clnMotivo.ReadOnly = true;
            // 
            // PainelConsultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvConsultas);
            Name = "PainelConsultas";
            Size = new Size(555, 574);
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvConsultas;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNomeDoCliente;
        private DataGridViewTextBoxColumn clnCPFdoCliente;
        private DataGridViewTextBoxColumn clnData;
        private DataGridViewTextBoxColumn clnHorario;
        private DataGridViewTextBoxColumn clnMotivo;
    }
}
