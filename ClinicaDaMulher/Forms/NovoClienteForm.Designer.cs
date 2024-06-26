﻿namespace ClinicaDaMulher.Forms
{
    partial class NovoClienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoClienteForm));
            btnCadastrar = new Button();
            btnCancelar = new Button();
            mtxCpf = new MaskedTextBox();
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            mtxTelefone = new MaskedTextBox();
            label4 = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(243, 250);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(133, 250);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // mtxCpf
            // 
            mtxCpf.Font = new Font("Segoe UI", 12F);
            mtxCpf.Location = new Point(12, 179);
            mtxCpf.Mask = "000\\.000\\.000-00";
            mtxCpf.Name = "mtxCpf";
            mtxCpf.Size = new Size(149, 34);
            mtxCpf.TabIndex = 36;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(12, 100);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(325, 34);
            txtNome.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(79, 31);
            label2.TabIndex = 38;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 145);
            label3.Name = "label3";
            label3.Size = new Size(54, 31);
            label3.TabIndex = 39;
            label3.Text = "CPF";
            // 
            // mtxTelefone
            // 
            mtxTelefone.Font = new Font("Segoe UI", 12F);
            mtxTelefone.Location = new Point(188, 179);
            mtxTelefone.Mask = "(99) 00000-0000";
            mtxTelefone.Name = "mtxTelefone";
            mtxTelefone.Size = new Size(149, 34);
            mtxTelefone.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(188, 145);
            label4.Name = "label4";
            label4.Size = new Size(105, 31);
            label4.TabIndex = 41;
            label4.Text = "Telefone";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlLightLight;
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(196, 41);
            lblTitulo.TabIndex = 35;
            lblTitulo.Text = "Novo cliente";
            // 
            // NovoClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 40, 83);
            ClientSize = new Size(351, 293);
            ControlBox = false;
            Controls.Add(lblTitulo);
            Controls.Add(label4);
            Controls.Add(mtxTelefone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(mtxCpf);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NovoClienteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cliente";
            Load += NovoClienteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Button btnCancelar;
        private MaskedTextBox mtxCpf;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private MaskedTextBox mtxTelefone;
        private Label label4;
        private Label lblTitulo;
    }
}