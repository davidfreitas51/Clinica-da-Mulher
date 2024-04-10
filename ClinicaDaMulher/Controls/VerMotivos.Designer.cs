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
            btnLimpar = new Button();
            panel2 = new Panel();
            btnBuscar = new Button();
            panel1 = new Panel();
            btnExcluirMotivo = new Button();
            btnEditarMotivo = new Button();
            btnNovoMotivo = new Button();
            panel3 = new Panel();
            label3 = new Label();
            txtMotivo = new TextBox();
            painelLegal.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // painelLegal
            // 
            painelLegal.BackColor = Color.FromArgb(167, 38, 135);
            painelLegal.Controls.Add(btnLimpar);
            painelLegal.Controls.Add(panel2);
            painelLegal.Controls.Add(panel1);
            painelLegal.Controls.Add(panel3);
            painelLegal.Dock = DockStyle.Fill;
            painelLegal.Location = new Point(0, 0);
            painelLegal.Name = "painelLegal";
            painelLegal.Size = new Size(847, 84);
            painelLegal.TabIndex = 1;
            // 
            // btnLimpar
            // 
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Image = (Image)resources.GetObject("btnLimpar.Image");
            btnLimpar.Location = new Point(29, 6);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(70, 70);
            btnLimpar.TabIndex = 60;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBuscar);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(466, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(99, 84);
            panel2.TabIndex = 55;
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(167, 38, 135);
            btnBuscar.Location = new Point(30, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(64, 64);
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
            btnExcluirMotivo.BackgroundImage = (Image)resources.GetObject("btnExcluirMotivo.BackgroundImage");
            btnExcluirMotivo.BackgroundImageLayout = ImageLayout.Stretch;
            btnExcluirMotivo.FlatAppearance.BorderSize = 0;
            btnExcluirMotivo.FlatStyle = FlatStyle.Flat;
            btnExcluirMotivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirMotivo.ForeColor = SystemColors.ControlLightLight;
            btnExcluirMotivo.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirMotivo.Location = new Point(200, 4);
            btnExcluirMotivo.Name = "btnExcluirMotivo";
            btnExcluirMotivo.Size = new Size(70, 70);
            btnExcluirMotivo.TabIndex = 50;
            btnExcluirMotivo.UseVisualStyleBackColor = false;
            btnExcluirMotivo.Click += btnExcluirMotivo_Click;
            // 
            // btnEditarMotivo
            // 
            btnEditarMotivo.BackgroundImage = (Image)resources.GetObject("btnEditarMotivo.BackgroundImage");
            btnEditarMotivo.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditarMotivo.FlatAppearance.BorderSize = 0;
            btnEditarMotivo.FlatStyle = FlatStyle.Flat;
            btnEditarMotivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarMotivo.ForeColor = SystemColors.ControlLightLight;
            btnEditarMotivo.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarMotivo.Location = new Point(120, 4);
            btnEditarMotivo.Name = "btnEditarMotivo";
            btnEditarMotivo.Size = new Size(70, 70);
            btnEditarMotivo.TabIndex = 49;
            btnEditarMotivo.UseVisualStyleBackColor = false;
            btnEditarMotivo.Click += btnEditarMotivo_Click;
            // 
            // btnNovoMotivo
            // 
            btnNovoMotivo.BackColor = Color.Transparent;
            btnNovoMotivo.BackgroundImage = (Image)resources.GetObject("btnNovoMotivo.BackgroundImage");
            btnNovoMotivo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNovoMotivo.FlatAppearance.BorderSize = 0;
            btnNovoMotivo.FlatStyle = FlatStyle.Flat;
            btnNovoMotivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovoMotivo.ForeColor = SystemColors.ControlLightLight;
            btnNovoMotivo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovoMotivo.Location = new Point(40, 3);
            btnNovoMotivo.Name = "btnNovoMotivo";
            btnNovoMotivo.Size = new Size(70, 70);
            btnNovoMotivo.TabIndex = 48;
            btnNovoMotivo.UseVisualStyleBackColor = false;
            btnNovoMotivo.Click += btnNovaRazao_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtMotivo);
            panel3.Location = new Point(118, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(362, 84);
            panel3.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(10, 6);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 52;
            label3.Text = "Motivo";
            // 
            // txtMotivo
            // 
            txtMotivo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMotivo.Location = new Point(10, 38);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(206, 31);
            txtMotivo.TabIndex = 53;
            // 
            // VerMotivos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(painelLegal);
            Name = "VerMotivos";
            Size = new Size(847, 84);
            painelLegal.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panel2;
        private Button btnLimpar;
        private Panel panel3;
    }
}
