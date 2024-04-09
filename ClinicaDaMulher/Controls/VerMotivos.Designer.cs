namespace ClinicaDaMulher.Controls
{
    partial class VerMotivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerMotivos));
            painelLegal = new Panel();
            btnBuscar = new Button();
            panel1 = new Panel();
            btnExcluirMotivo = new Button();
            btnEditarMotivo = new Button();
            btnNovoMotivo = new Button();
            txtMotivo = new TextBox();
            label3 = new Label();
            painelLegal.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // painelLegal
            // 
            painelLegal.BackColor = Color.FromArgb(167, 38, 135);
            painelLegal.Controls.Add(btnBuscar);
            painelLegal.Controls.Add(panel1);
            painelLegal.Controls.Add(txtMotivo);
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
            btnBuscar.Location = new Point(203, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(46, 46);
            btnBuscar.TabIndex = 51;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExcluirMotivo);
            panel1.Controls.Add(btnEditarMotivo);
            panel1.Controls.Add(btnNovoMotivo);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(565, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 84);
            panel1.TabIndex = 54;
            // 
            // btnExcluirMotivo
            // 
            btnExcluirMotivo.BackColor = Color.FromArgb(69, 71, 106);
            btnExcluirMotivo.FlatAppearance.BorderSize = 0;
            btnExcluirMotivo.FlatStyle = FlatStyle.Flat;
            btnExcluirMotivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirMotivo.ForeColor = SystemColors.ControlLightLight;
            btnExcluirMotivo.Image = (Image)resources.GetObject("btnExcluirMotivo.Image");
            btnExcluirMotivo.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirMotivo.Location = new Point(196, 8);
            btnExcluirMotivo.Name = "btnExcluirMotivo";
            btnExcluirMotivo.Size = new Size(70, 70);
            btnExcluirMotivo.TabIndex = 50;
            btnExcluirMotivo.UseVisualStyleBackColor = false;
            btnExcluirMotivo.Click += btnExcluirMotivo_Click;
            // 
            // btnEditarMotivo
            // 
            btnEditarMotivo.BackColor = Color.FromArgb(69, 71, 106);
            btnEditarMotivo.FlatAppearance.BorderSize = 0;
            btnEditarMotivo.FlatStyle = FlatStyle.Flat;
            btnEditarMotivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarMotivo.ForeColor = SystemColors.ControlLightLight;
            btnEditarMotivo.Image = (Image)resources.GetObject("btnEditarMotivo.Image");
            btnEditarMotivo.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarMotivo.Location = new Point(106, 7);
            btnEditarMotivo.Name = "btnEditarMotivo";
            btnEditarMotivo.Size = new Size(70, 70);
            btnEditarMotivo.TabIndex = 49;
            btnEditarMotivo.UseVisualStyleBackColor = false;
            // 
            // btnNovoMotivo
            // 
            btnNovoMotivo.BackColor = Color.FromArgb(69, 71, 106);
            btnNovoMotivo.FlatAppearance.BorderSize = 0;
            btnNovoMotivo.FlatStyle = FlatStyle.Flat;
            btnNovoMotivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovoMotivo.ForeColor = SystemColors.ControlLightLight;
            btnNovoMotivo.Image = (Image)resources.GetObject("btnNovoMotivo.Image");
            btnNovoMotivo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovoMotivo.Location = new Point(3, 8);
            btnNovoMotivo.Name = "btnNovoMotivo";
            btnNovoMotivo.Size = new Size(70, 70);
            btnNovoMotivo.TabIndex = 48;
            btnNovoMotivo.UseVisualStyleBackColor = false;
            btnNovoMotivo.Click += btnNovaRazao_Click;
            // 
            // txtMotivo
            // 
            txtMotivo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMotivo.Location = new Point(17, 39);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(153, 31);
            txtMotivo.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(17, 8);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 52;
            label3.Text = "Motivo";
            // 
            // VerMotivos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(painelLegal);
            Name = "VerMotivos";
            Size = new Size(847, 84);
            painelLegal.ResumeLayout(false);
            painelLegal.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel painelLegal;
        private TextBox txtMotivo;
        private Label label3;
        private Panel panel1;
        private Button btnExcluirMotivo;
        private Button btnEditarMotivo;
        private Button btnNovoMotivo;
        private Button btnBuscar;
    }
}
