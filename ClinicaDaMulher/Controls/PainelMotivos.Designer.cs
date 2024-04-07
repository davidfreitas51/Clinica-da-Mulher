namespace ClinicaDaMulher.Controls
{
    partial class PainelMotivos
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
            dgvMotivos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnMotivo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMotivos).BeginInit();
            SuspendLayout();
            // 
            // dgvMotivos
            // 
            dgvMotivos.AllowUserToAddRows = false;
            dgvMotivos.AllowUserToDeleteRows = false;
            dgvMotivos.AllowUserToOrderColumns = true;
            dgvMotivos.AllowUserToResizeColumns = false;
            dgvMotivos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvMotivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMotivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMotivos.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMotivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMotivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMotivos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnMotivo });
            dgvMotivos.Dock = DockStyle.Fill;
            dgvMotivos.EnableHeadersVisualStyles = false;
            dgvMotivos.GridColor = Color.Black;
            dgvMotivos.Location = new Point(0, 0);
            dgvMotivos.Name = "dgvMotivos";
            dgvMotivos.ReadOnly = true;
            dgvMotivos.RowHeadersVisible = false;
            dgvMotivos.RowHeadersWidth = 51;
            dgvMotivos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMotivos.Size = new Size(447, 583);
            dgvMotivos.TabIndex = 3;
            dgvMotivos.CellContentClick += dgvMotivos_CellContentClick;
            // 
            // clnId
            // 
            clnId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clnId.DataPropertyName = "Id";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clnId.DefaultCellStyle = dataGridViewCellStyle3;
            clnId.HeaderText = "ID";
            clnId.MinimumWidth = 6;
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            // 
            // clnMotivo
            // 
            clnMotivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clnMotivo.DataPropertyName = "Nome";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clnMotivo.DefaultCellStyle = dataGridViewCellStyle4;
            clnMotivo.HeaderText = "Motivo";
            clnMotivo.MinimumWidth = 6;
            clnMotivo.Name = "clnMotivo";
            clnMotivo.ReadOnly = true;
            // 
            // PainelMotivos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvMotivos);
            Name = "PainelMotivos";
            Size = new Size(447, 583);
            ((System.ComponentModel.ISupportInitialize)dgvMotivos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvMotivos;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnMotivo;
    }
}
