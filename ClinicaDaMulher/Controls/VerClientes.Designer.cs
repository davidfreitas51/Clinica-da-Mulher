namespace ClinicaDaMulher.Controls
{
    partial class VerClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerClientes));
            painelLegal = new Panel();
            panel3 = new Panel();
            btnLimpar = new Button();
            panel2 = new Panel();
            btnBuscar = new Button();
            panel1 = new Panel();
            btnNovoCliente = new Button();
            btnDeletarCliente = new Button();
            btnEditarCliente = new Button();
            txtNome = new TextBox();
            label1 = new Label();
            txtCpf = new TextBox();
            label3 = new Label();
            painelLegal.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // painelLegal
            // 
            painelLegal.BackColor = Color.FromArgb(167, 38, 135);
            painelLegal.Controls.Add(panel3);
            painelLegal.Controls.Add(panel2);
            painelLegal.Controls.Add(panel1);
            painelLegal.Controls.Add(txtNome);
            painelLegal.Controls.Add(label1);
            painelLegal.Controls.Add(txtCpf);
            painelLegal.Controls.Add(label3);
            painelLegal.Dock = DockStyle.Fill;
            painelLegal.Location = new Point(0, 0);
            painelLegal.Name = "painelLegal";
            painelLegal.Size = new Size(1261, 84);
            painelLegal.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLimpar);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(130, 84);
            panel3.TabIndex = 60;
            // 
            // btnLimpar
            // 
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Image = (Image)resources.GetObject("btnLimpar.Image");
            btnLimpar.Location = new Point(29, 6);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(70, 70);
            btnLimpar.TabIndex = 59;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBuscar);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(838, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(132, 84);
            panel2.TabIndex = 54;
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(167, 38, 135);
            btnBuscar.Location = new Point(31, 13);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(64, 64);
            btnBuscar.TabIndex = 50;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNovoCliente);
            panel1.Controls.Add(btnDeletarCliente);
            panel1.Controls.Add(btnEditarCliente);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(970, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 84);
            panel1.TabIndex = 53;
            // 
            // btnNovoCliente
            // 
            btnNovoCliente.BackColor = Color.Transparent;
            btnNovoCliente.BackgroundImage = (Image)resources.GetObject("btnNovoCliente.BackgroundImage");
            btnNovoCliente.FlatAppearance.BorderSize = 0;
            btnNovoCliente.FlatStyle = FlatStyle.Flat;
            btnNovoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovoCliente.ForeColor = SystemColors.ControlLightLight;
            btnNovoCliente.Location = new Point(38, 10);
            btnNovoCliente.Name = "btnNovoCliente";
            btnNovoCliente.Size = new Size(70, 70);
            btnNovoCliente.TabIndex = 47;
            btnNovoCliente.UseVisualStyleBackColor = false;
            btnNovoCliente.Click += btnNovoCliente_Click;
            // 
            // btnDeletarCliente
            // 
            btnDeletarCliente.BackColor = Color.Transparent;
            btnDeletarCliente.BackgroundImage = (Image)resources.GetObject("btnDeletarCliente.BackgroundImage");
            btnDeletarCliente.FlatAppearance.BorderSize = 0;
            btnDeletarCliente.FlatStyle = FlatStyle.Flat;
            btnDeletarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletarCliente.ForeColor = SystemColors.ControlLightLight;
            btnDeletarCliente.Location = new Point(206, 10);
            btnDeletarCliente.Name = "btnDeletarCliente";
            btnDeletarCliente.Size = new Size(70, 70);
            btnDeletarCliente.TabIndex = 52;
            btnDeletarCliente.UseVisualStyleBackColor = false;
            btnDeletarCliente.Click += btnDeletarCliente_Click;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.BackColor = Color.Transparent;
            btnEditarCliente.BackgroundImage = (Image)resources.GetObject("btnEditarCliente.BackgroundImage");
            btnEditarCliente.FlatAppearance.BorderSize = 0;
            btnEditarCliente.FlatStyle = FlatStyle.Flat;
            btnEditarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarCliente.ForeColor = SystemColors.ControlLightLight;
            btnEditarCliente.Location = new Point(122, 10);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(70, 70);
            btnEditarCliente.TabIndex = 51;
            btnEditarCliente.UseVisualStyleBackColor = false;
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10.2F);
            txtNome.Location = new Point(136, 39);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(185, 30);
            txtNome.TabIndex = 49;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(136, 6);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 48;
            label1.Text = "Nome";
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 10.2F);
            txtCpf.Location = new Point(345, 39);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(160, 30);
            txtCpf.TabIndex = 47;
            txtCpf.KeyPress += txtCpf_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(345, 10);
            label3.Name = "label3";
            label3.Size = new Size(46, 28);
            label3.TabIndex = 46;
            label3.Text = "CPF";
            // 
            // VerClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(painelLegal);
            Name = "VerClientes";
            Size = new Size(1261, 84);
            painelLegal.ResumeLayout(false);
            painelLegal.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel painelLegal;
        private TextBox txtCpf;
        private Label label3;
        private TextBox txtNome;
        private Label label1;
        private Button btnBuscar;
        private Button btnNovoCliente;
        private Button btnDeletarCliente;
        private Button btnEditarCliente;
        private Panel panel1;
        private Panel panel2;
        private Button btnLimpar;
        private Panel panel3;
    }
}
