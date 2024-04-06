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
            btnBuscar = new Button();
            txtNome = new TextBox();
            label1 = new Label();
            txtCpf = new TextBox();
            label3 = new Label();
            painelLegal.SuspendLayout();
            SuspendLayout();
            // 
            // painelLegal
            // 
            painelLegal.BackColor = Color.FromArgb(167, 38, 135);
            painelLegal.Controls.Add(btnBuscar);
            painelLegal.Controls.Add(txtNome);
            painelLegal.Controls.Add(label1);
            painelLegal.Controls.Add(txtCpf);
            painelLegal.Controls.Add(label3);
            painelLegal.Dock = DockStyle.Fill;
            painelLegal.Location = new Point(0, 0);
            painelLegal.Name = "painelLegal";
            painelLegal.Size = new Size(847, 84);
            painelLegal.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(167, 38, 135);
            btnBuscar.Location = new Point(386, 26);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(46, 46);
            btnBuscar.TabIndex = 50;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(16, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(160, 31);
            txtNome.TabIndex = 49;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(16, 10);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 48;
            label1.Text = "Nome";
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCpf.Location = new Point(196, 41);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(160, 31);
            txtCpf.TabIndex = 47;
            txtCpf.KeyPress += txtCpf_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(196, 10);
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
            Size = new Size(847, 84);
            painelLegal.ResumeLayout(false);
            painelLegal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel painelLegal;
        private TextBox txtCpf;
        private Label label3;
        private TextBox txtNome;
        private Label label1;
        private Button btnBuscar;
    }
}
