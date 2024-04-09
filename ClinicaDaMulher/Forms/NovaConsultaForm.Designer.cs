﻿namespace ClinicaDaMulher.Forms
{
    partial class NovaConsultaForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            mtxCpf = new MaskedTextBox();
            cbxMotivo = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            btnMarcar = new Button();
            btnCancelar = new Button();
            mtxHorario = new MaskedTextBox();
            mtxData = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 41);
            label1.TabIndex = 36;
            label1.Text = "Nova consulta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(17, 162);
            label4.Name = "label4";
            label4.Size = new Size(92, 31);
            label4.TabIndex = 49;
            label4.Text = "Motivo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(17, 77);
            label3.Name = "label3";
            label3.Size = new Size(164, 31);
            label3.TabIndex = 47;
            label3.Text = "CPF da cliente";
            // 
            // mtxCpf
            // 
            mtxCpf.Font = new Font("Segoe UI", 12F);
            mtxCpf.Location = new Point(15, 111);
            mtxCpf.Mask = "000\\.000\\.000-00";
            mtxCpf.Name = "mtxCpf";
            mtxCpf.Size = new Size(174, 34);
            mtxCpf.TabIndex = 44;
            // 
            // cbxMotivo
            // 
            cbxMotivo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxMotivo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxMotivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxMotivo.FormattingEnabled = true;
            cbxMotivo.Location = new Point(17, 196);
            cbxMotivo.MaxLength = 100;
            cbxMotivo.Name = "cbxMotivo";
            cbxMotivo.Size = new Size(171, 36);
            cbxMotivo.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(266, 77);
            label5.Name = "label5";
            label5.Size = new Size(64, 31);
            label5.TabIndex = 55;
            label5.Text = "Data";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(265, 164);
            label6.Name = "label6";
            label6.Size = new Size(97, 31);
            label6.TabIndex = 56;
            label6.Text = "Horário";
            // 
            // btnMarcar
            // 
            btnMarcar.Location = new Point(307, 271);
            btnMarcar.Name = "btnMarcar";
            btnMarcar.Size = new Size(94, 29);
            btnMarcar.TabIndex = 57;
            btnMarcar.Text = "Marcar";
            btnMarcar.UseVisualStyleBackColor = true;
            btnMarcar.Click += btnMarcar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(207, 271);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 58;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // mtxHorario
            // 
            mtxHorario.Font = new Font("Segoe UI", 12F);
            mtxHorario.Location = new Point(266, 198);
            mtxHorario.Mask = "00:00";
            mtxHorario.Name = "mtxHorario";
            mtxHorario.Size = new Size(54, 34);
            mtxHorario.TabIndex = 59;
            mtxHorario.ValidatingType = typeof(DateTime);
            // 
            // mtxData
            // 
            mtxData.Font = new Font("Segoe UI", 12F);
            mtxData.Location = new Point(265, 120);
            mtxData.Mask = "00/00/0000";
            mtxData.Name = "mtxData";
            mtxData.Size = new Size(125, 34);
            mtxData.TabIndex = 60;
            mtxData.ValidatingType = typeof(DateTime);
            // 
            // NovaConsultaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 40, 83);
            ClientSize = new Size(428, 322);
            ControlBox = false;
            Controls.Add(mtxData);
            Controls.Add(mtxHorario);
            Controls.Add(btnCancelar);
            Controls.Add(btnMarcar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cbxMotivo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(mtxCpf);
            Controls.Add(label1);
            Name = "NovaConsultaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nova consulta";
            Load += NovaConsultaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label4;
        private Label label3;
        private MaskedTextBox mtxCpf;
        private ComboBox cbxMotivo;
        private Label label5;
        private Label label6;
        private Button btnMarcar;
        private Button btnCancelar;
        private MaskedTextBox mtxHorario;
        private MaskedTextBox mtxData;
    }
}