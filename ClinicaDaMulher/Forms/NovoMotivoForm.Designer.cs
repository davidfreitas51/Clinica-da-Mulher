﻿namespace ClinicaDaMulher.Forms
{
    partial class NovoMotivoForm
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
            label2 = new Label();
            txtNomeDoMotivo = new TextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
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
            label1.Size = new Size(202, 41);
            label1.TabIndex = 36;
            label1.Text = "Novo motivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(79, 31);
            label2.TabIndex = 40;
            label2.Text = "Nome";
            // 
            // txtNomeDoMotivo
            // 
            txtNomeDoMotivo.Font = new Font("Segoe UI", 12F);
            txtNomeDoMotivo.Location = new Point(12, 92);
            txtNomeDoMotivo.Name = "txtNomeDoMotivo";
            txtNomeDoMotivo.Size = new Size(251, 34);
            txtNomeDoMotivo.TabIndex = 39;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(192, 151);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 41;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(70, 151);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // NovoMotivoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 52, 77);
            ClientSize = new Size(300, 192);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(label2);
            Controls.Add(txtNomeDoMotivo);
            Controls.Add(label1);
            Name = "NovoMotivoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Novo motivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNomeDoMotivo;
        private Button btnRegistrar;
        private Button btnCancelar;
    }
}