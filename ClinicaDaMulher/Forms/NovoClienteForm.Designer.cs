namespace ClinicaDaMulher.Forms
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
            btnCadastrar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            mtxCpf = new MaskedTextBox();
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            mtxTelefone = new MaskedTextBox();
            label4 = new Label();
            cbxEstado = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(258, 409);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(148, 409);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 41);
            label1.TabIndex = 35;
            label1.Text = "Novo cliente";
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
            txtNome.Size = new Size(288, 34);
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
            mtxTelefone.Location = new Point(12, 265);
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
            label4.Location = new Point(12, 231);
            label4.Name = "label4";
            label4.Size = new Size(105, 31);
            label4.TabIndex = 41;
            label4.Text = "Telefone";
            // 
            // cbxEstado
            // 
            cbxEstado.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxEstado.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Location = new Point(381, 100);
            cbxEstado.MaxLength = 2;
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(76, 36);
            cbxEstado.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(379, 66);
            label5.Name = "label5";
            label5.Size = new Size(85, 31);
            label5.TabIndex = 43;
            label5.Text = "Estado";
            // 
            // NovoClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 40, 83);
            ClientSize = new Size(489, 450);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(cbxEstado);
            Controls.Add(label4);
            Controls.Add(mtxTelefone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(mtxCpf);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Name = "NovoClienteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NovoCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Button btnCancelar;
        private Label label1;
        private MaskedTextBox mtxCpf;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private MaskedTextBox mtxTelefone;
        private Label label4;
        private ComboBox cbxEstado;
        private Label label5;
    }
}