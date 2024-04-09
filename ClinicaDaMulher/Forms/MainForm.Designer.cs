namespace ClinicaDaMulher
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label5 = new Label();
            label1 = new Label();
            upperPanel = new Panel();
            pnlUpperControls = new Panel();
            pnlLogo = new Panel();
            panel2 = new Panel();
            btnVerMotivos = new Button();
            btnVerConsultas = new Button();
            btnVerClientes = new Button();
            painelDgv = new Panel();
            upperPanel.SuspendLayout();
            pnlLogo.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(137, 31, 110);
            label5.Font = new Font("Vivaldi", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(99, 33);
            label5.Name = "label5";
            label5.Size = new Size(120, 41);
            label5.TabIndex = 35;
            label5.Text = "Mulher";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(137, 31, 110);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(1, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 41);
            label1.TabIndex = 34;
            label1.Text = "Clínica da";
            // 
            // upperPanel
            // 
            upperPanel.Controls.Add(pnlUpperControls);
            upperPanel.Controls.Add(pnlLogo);
            upperPanel.Dock = DockStyle.Top;
            upperPanel.Location = new Point(0, 0);
            upperPanel.Name = "upperPanel";
            upperPanel.Size = new Size(1428, 77);
            upperPanel.TabIndex = 44;
            // 
            // pnlUpperControls
            // 
            pnlUpperControls.Dock = DockStyle.Top;
            pnlUpperControls.Location = new Point(240, 0);
            pnlUpperControls.Name = "pnlUpperControls";
            pnlUpperControls.Size = new Size(1188, 77);
            pnlUpperControls.TabIndex = 46;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(137, 31, 110);
            pnlLogo.Controls.Add(label1);
            pnlLogo.Controls.Add(label5);
            pnlLogo.Dock = DockStyle.Left;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(240, 77);
            pnlLogo.TabIndex = 46;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(55, 40, 83);
            panel2.Controls.Add(btnVerMotivos);
            panel2.Controls.Add(btnVerConsultas);
            panel2.Controls.Add(btnVerClientes);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 866);
            panel2.TabIndex = 47;
            // 
            // btnVerMotivos
            // 
            btnVerMotivos.BackColor = Color.FromArgb(55, 40, 83);
            btnVerMotivos.FlatAppearance.BorderSize = 0;
            btnVerMotivos.FlatStyle = FlatStyle.Flat;
            btnVerMotivos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerMotivos.ForeColor = SystemColors.ControlLightLight;
            btnVerMotivos.Image = (Image)resources.GetObject("btnVerMotivos.Image");
            btnVerMotivos.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerMotivos.Location = new Point(0, 133);
            btnVerMotivos.Name = "btnVerMotivos";
            btnVerMotivos.Size = new Size(240, 70);
            btnVerMotivos.TabIndex = 50;
            btnVerMotivos.Text = "            Motivos";
            btnVerMotivos.UseVisualStyleBackColor = false;
            btnVerMotivos.Click += btnVerMotivos_Click;
            btnVerMotivos.MouseEnter += btnVerMotivos_MouseEnter;
            btnVerMotivos.MouseLeave += btnVerMotivos_MouseLeave;
            // 
            // btnVerConsultas
            // 
            btnVerConsultas.BackColor = Color.FromArgb(55, 40, 83);
            btnVerConsultas.FlatAppearance.BorderSize = 0;
            btnVerConsultas.FlatStyle = FlatStyle.Flat;
            btnVerConsultas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerConsultas.ForeColor = SystemColors.ControlLightLight;
            btnVerConsultas.Image = (Image)resources.GetObject("btnVerConsultas.Image");
            btnVerConsultas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerConsultas.Location = new Point(0, 3);
            btnVerConsultas.Name = "btnVerConsultas";
            btnVerConsultas.Size = new Size(240, 70);
            btnVerConsultas.TabIndex = 51;
            btnVerConsultas.Text = "            Consultas";
            btnVerConsultas.UseVisualStyleBackColor = false;
            btnVerConsultas.Click += btnVerConsultas_Click_1;
            btnVerConsultas.MouseEnter += btnVerConsultas_MouseEnter;
            btnVerConsultas.MouseLeave += btnVerConsultas_MouseLeave;
            // 
            // btnVerClientes
            // 
            btnVerClientes.BackColor = Color.FromArgb(55, 40, 83);
            btnVerClientes.FlatAppearance.BorderSize = 0;
            btnVerClientes.FlatStyle = FlatStyle.Flat;
            btnVerClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerClientes.ForeColor = SystemColors.ControlLightLight;
            btnVerClientes.Image = (Image)resources.GetObject("btnVerClientes.Image");
            btnVerClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerClientes.Location = new Point(0, 69);
            btnVerClientes.Name = "btnVerClientes";
            btnVerClientes.Size = new Size(240, 70);
            btnVerClientes.TabIndex = 49;
            btnVerClientes.Text = "            Clientes";
            btnVerClientes.UseVisualStyleBackColor = false;
            btnVerClientes.Click += btnVerClientes_Click;
            btnVerClientes.MouseEnter += btnVerClientes_MouseEnter;
            btnVerClientes.MouseLeave += btnVerClientes_MouseLeave;
            // 
            // painelDgv
            // 
            painelDgv.BackColor = Color.FromArgb(36, 26, 55);
            painelDgv.Dock = DockStyle.Fill;
            painelDgv.Location = new Point(239, 77);
            painelDgv.Name = "painelDgv";
            painelDgv.Size = new Size(1189, 866);
            painelDgv.TabIndex = 48;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(167, 38, 135);
            ClientSize = new Size(1428, 943);
            Controls.Add(painelDgv);
            Controls.Add(panel2);
            Controls.Add(upperPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clínica da Mulher";
            upperPanel.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private Label label1;
        private Panel upperPanel;
        private Panel pnlUpperControls;
        private Panel pnlLogo;
        private Panel panel2;
        private Button btnVerMotivos;
        private Button btnVerClientes;
        private Panel painelDgv;
        private Button btnVerConsultas;
    }
}
