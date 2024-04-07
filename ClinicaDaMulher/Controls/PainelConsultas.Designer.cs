﻿namespace ClinicaDaMulher.Controls
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            dgvConsultas = new DataGridView();
            clnNomeDoCliente = new DataGridViewTextBoxColumn();
            clnCPFdoCliente = new DataGridViewTextBoxColumn();
            clmData = new DataGridViewTextBoxColumn();
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
            dgvConsultas.Columns.AddRange(new DataGridViewColumn[] { clnNomeDoCliente, clnCPFdoCliente, clmData, clnHorario, clnMotivo });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvConsultas.DefaultCellStyle = dataGridViewCellStyle8;
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
            // clnNomeDoCliente
            // 
            clnNomeDoCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clnNomeDoCliente.DataPropertyName = "Cliente.Nome";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clnNomeDoCliente.DefaultCellStyle = dataGridViewCellStyle3;
            clnNomeDoCliente.HeaderText = "Cliente";
            clnNomeDoCliente.MinimumWidth = 6;
            clnNomeDoCliente.Name = "clnNomeDoCliente";
            clnNomeDoCliente.ReadOnly = true;
            // 
            // clnCPFdoCliente
            // 
            clnCPFdoCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clnCPFdoCliente.DataPropertyName = "Cliente.CPF";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clnCPFdoCliente.DefaultCellStyle = dataGridViewCellStyle4;
            clnCPFdoCliente.HeaderText = "CPF";
            clnCPFdoCliente.MinimumWidth = 6;
            clnCPFdoCliente.Name = "clnCPFdoCliente";
            clnCPFdoCliente.ReadOnly = true;
            // 
            // clmData
            // 
            clmData.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmData.DataPropertyName = "Data";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmData.DefaultCellStyle = dataGridViewCellStyle5;
            clmData.HeaderText = "Data";
            clmData.MinimumWidth = 6;
            clmData.Name = "clmData";
            clmData.ReadOnly = true;
            // 
            // clnHorario
            // 
            clnHorario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clnHorario.DataPropertyName = "Hora";
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 10.2F);
            clnHorario.DefaultCellStyle = dataGridViewCellStyle6;
            clnHorario.HeaderText = "Horário";
            clnHorario.MinimumWidth = 6;
            clnHorario.Name = "clnHorario";
            clnHorario.ReadOnly = true;
            // 
            // clnMotivo
            // 
            clnMotivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clnMotivo.DataPropertyName = "Motivo";
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 10.2F);
            clnMotivo.DefaultCellStyle = dataGridViewCellStyle7;
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
        private DataGridViewTextBoxColumn clnNomeDoCliente;
        private DataGridViewTextBoxColumn clnCPFdoCliente;
        private DataGridViewTextBoxColumn clmData;
        private DataGridViewTextBoxColumn clnHorario;
        private DataGridViewTextBoxColumn clnMotivo;
    }
}
