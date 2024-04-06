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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label5 = new Label();
            label1 = new Label();
            upperPanel = new Panel();
            pnlUpperControls = new Panel();
            pnlLogo = new Panel();
            timerVer = new System.Windows.Forms.Timer(components);
            timerClientes = new System.Windows.Forms.Timer(components);
            timerRazoes = new System.Windows.Forms.Timer(components);
            timerView = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlVer = new Panel();
            btnVerRazões = new Button();
            btnVerConsultas = new Button();
            btnVer = new Button();
            btnVerClientes = new Button();
            pnlClientes = new Panel();
            btnExcluirCliente = new Button();
            btnNovoCliente = new Button();
            btnEditarCliente = new Button();
            btnClientes = new Button();
            pnlRazoes = new Panel();
            btnExcluirRazao = new Button();
            btnEditarRazao = new Button();
            btnNovaRazao = new Button();
            btnRazoes = new Button();
            painelDgv = new Panel();
            upperPanel.SuspendLayout();
            pnlLogo.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlVer.SuspendLayout();
            pnlClientes.SuspendLayout();
            pnlRazoes.SuspendLayout();
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
            // timerVer
            // 
            timerVer.Interval = 1;
            // 
            // timerClientes
            // 
            timerClientes.Interval = 1;
            timerClientes.Tick += timerClientes_Tick;
            // 
            // timerRazoes
            // 
            timerRazoes.Interval = 1;
            timerRazoes.Tick += timerRazoes_Tick;
            // 
            // timerView
            // 
            timerView.Interval = 1;
            timerView.Tick += timerView_Tick;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 866);
            panel2.TabIndex = 47;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(50, 52, 77);
            flowLayoutPanel1.Controls.Add(pnlVer);
            flowLayoutPanel1.Controls.Add(pnlClientes);
            flowLayoutPanel1.Controls.Add(pnlRazoes);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(240, 866);
            flowLayoutPanel1.TabIndex = 45;
            // 
            // pnlVer
            // 
            pnlVer.BackColor = Color.White;
            pnlVer.Controls.Add(btnVerRazões);
            pnlVer.Controls.Add(btnVerConsultas);
            pnlVer.Controls.Add(btnVer);
            pnlVer.Controls.Add(btnVerClientes);
            pnlVer.Location = new Point(3, 3);
            pnlVer.MaximumSize = new Size(240, 280);
            pnlVer.MinimumSize = new Size(240, 70);
            pnlVer.Name = "pnlVer";
            pnlVer.Size = new Size(240, 280);
            pnlVer.TabIndex = 48;
            // 
            // btnVerRazões
            // 
            btnVerRazões.BackColor = Color.FromArgb(69, 71, 106);
            btnVerRazões.FlatAppearance.BorderSize = 0;
            btnVerRazões.FlatStyle = FlatStyle.Flat;
            btnVerRazões.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerRazões.ForeColor = SystemColors.ControlLightLight;
            btnVerRazões.Image = (Image)resources.GetObject("btnVerRazões.Image");
            btnVerRazões.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerRazões.Location = new Point(0, 210);
            btnVerRazões.Name = "btnVerRazões";
            btnVerRazões.Size = new Size(240, 70);
            btnVerRazões.TabIndex = 50;
            btnVerRazões.Text = "            Razões";
            btnVerRazões.UseVisualStyleBackColor = false;
            btnVerRazões.Click += btnVerRazões_Click;
            // 
            // btnVerConsultas
            // 
            btnVerConsultas.BackColor = Color.FromArgb(69, 71, 106);
            btnVerConsultas.FlatAppearance.BorderSize = 0;
            btnVerConsultas.FlatStyle = FlatStyle.Flat;
            btnVerConsultas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerConsultas.ForeColor = SystemColors.ControlLightLight;
            btnVerConsultas.Image = (Image)resources.GetObject("btnVerConsultas.Image");
            btnVerConsultas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerConsultas.Location = new Point(0, 70);
            btnVerConsultas.Name = "btnVerConsultas";
            btnVerConsultas.Size = new Size(240, 70);
            btnVerConsultas.TabIndex = 48;
            btnVerConsultas.Text = "            Consultas";
            btnVerConsultas.UseVisualStyleBackColor = false;
            btnVerConsultas.Click += btnVerConsultas_Click;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.FromArgb(50, 52, 77);
            btnVer.FlatAppearance.BorderSize = 0;
            btnVer.FlatStyle = FlatStyle.Flat;
            btnVer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVer.ForeColor = SystemColors.ControlLightLight;
            btnVer.Image = (Image)resources.GetObject("btnVer.Image");
            btnVer.ImageAlign = ContentAlignment.MiddleLeft;
            btnVer.Location = new Point(0, 0);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(240, 70);
            btnVer.TabIndex = 47;
            btnVer.Text = "            Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // btnVerClientes
            // 
            btnVerClientes.BackColor = Color.FromArgb(69, 71, 106);
            btnVerClientes.FlatAppearance.BorderSize = 0;
            btnVerClientes.FlatStyle = FlatStyle.Flat;
            btnVerClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerClientes.ForeColor = SystemColors.ControlLightLight;
            btnVerClientes.Image = (Image)resources.GetObject("btnVerClientes.Image");
            btnVerClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerClientes.Location = new Point(0, 140);
            btnVerClientes.Name = "btnVerClientes";
            btnVerClientes.Size = new Size(240, 70);
            btnVerClientes.TabIndex = 49;
            btnVerClientes.Text = "            Clientes";
            btnVerClientes.UseVisualStyleBackColor = false;
            btnVerClientes.Click += btnVerClientes_Click;
            // 
            // pnlClientes
            // 
            pnlClientes.BackColor = Color.White;
            pnlClientes.Controls.Add(btnExcluirCliente);
            pnlClientes.Controls.Add(btnNovoCliente);
            pnlClientes.Controls.Add(btnEditarCliente);
            pnlClientes.Controls.Add(btnClientes);
            pnlClientes.Location = new Point(3, 289);
            pnlClientes.MaximumSize = new Size(240, 280);
            pnlClientes.MinimumSize = new Size(240, 70);
            pnlClientes.Name = "pnlClientes";
            pnlClientes.Size = new Size(240, 70);
            pnlClientes.TabIndex = 45;
            // 
            // btnExcluirCliente
            // 
            btnExcluirCliente.BackColor = Color.FromArgb(69, 71, 106);
            btnExcluirCliente.FlatAppearance.BorderSize = 0;
            btnExcluirCliente.FlatStyle = FlatStyle.Flat;
            btnExcluirCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirCliente.ForeColor = SystemColors.ControlLightLight;
            btnExcluirCliente.Image = (Image)resources.GetObject("btnExcluirCliente.Image");
            btnExcluirCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirCliente.Location = new Point(0, 210);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.Size = new Size(240, 70);
            btnExcluirCliente.TabIndex = 46;
            btnExcluirCliente.Text = "              Excluir";
            btnExcluirCliente.UseVisualStyleBackColor = false;
            // 
            // btnNovoCliente
            // 
            btnNovoCliente.BackColor = Color.FromArgb(69, 71, 106);
            btnNovoCliente.FlatAppearance.BorderSize = 0;
            btnNovoCliente.FlatStyle = FlatStyle.Flat;
            btnNovoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovoCliente.ForeColor = SystemColors.ControlLightLight;
            btnNovoCliente.Image = (Image)resources.GetObject("btnNovoCliente.Image");
            btnNovoCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovoCliente.Location = new Point(-2, 70);
            btnNovoCliente.Name = "btnNovoCliente";
            btnNovoCliente.Size = new Size(240, 70);
            btnNovoCliente.TabIndex = 46;
            btnNovoCliente.Text = "             Novo";
            btnNovoCliente.UseVisualStyleBackColor = false;
            btnNovoCliente.Click += btnNovoCliente_Click;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.BackColor = Color.FromArgb(69, 71, 106);
            btnEditarCliente.FlatAppearance.BorderSize = 0;
            btnEditarCliente.FlatStyle = FlatStyle.Flat;
            btnEditarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarCliente.ForeColor = SystemColors.ControlLightLight;
            btnEditarCliente.Image = (Image)resources.GetObject("btnEditarCliente.Image");
            btnEditarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarCliente.Location = new Point(0, 140);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(240, 70);
            btnEditarCliente.TabIndex = 47;
            btnEditarCliente.Text = "             Editar";
            btnEditarCliente.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(50, 52, 77);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = SystemColors.ControlLightLight;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 0);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(240, 70);
            btnClientes.TabIndex = 46;
            btnClientes.Text = "            Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // pnlRazoes
            // 
            pnlRazoes.BackColor = Color.White;
            pnlRazoes.Controls.Add(btnExcluirRazao);
            pnlRazoes.Controls.Add(btnEditarRazao);
            pnlRazoes.Controls.Add(btnNovaRazao);
            pnlRazoes.Controls.Add(btnRazoes);
            pnlRazoes.Location = new Point(3, 365);
            pnlRazoes.MaximumSize = new Size(240, 280);
            pnlRazoes.MinimumSize = new Size(240, 70);
            pnlRazoes.Name = "pnlRazoes";
            pnlRazoes.Size = new Size(240, 70);
            pnlRazoes.TabIndex = 47;
            // 
            // btnExcluirRazao
            // 
            btnExcluirRazao.BackColor = Color.FromArgb(69, 71, 106);
            btnExcluirRazao.FlatAppearance.BorderSize = 0;
            btnExcluirRazao.FlatStyle = FlatStyle.Flat;
            btnExcluirRazao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirRazao.ForeColor = SystemColors.ControlLightLight;
            btnExcluirRazao.Image = (Image)resources.GetObject("btnExcluirRazao.Image");
            btnExcluirRazao.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirRazao.Location = new Point(0, 210);
            btnExcluirRazao.Name = "btnExcluirRazao";
            btnExcluirRazao.Size = new Size(240, 70);
            btnExcluirRazao.TabIndex = 49;
            btnExcluirRazao.Text = "            Excluir";
            btnExcluirRazao.UseVisualStyleBackColor = false;
            // 
            // btnEditarRazao
            // 
            btnEditarRazao.BackColor = Color.FromArgb(69, 71, 106);
            btnEditarRazao.FlatAppearance.BorderSize = 0;
            btnEditarRazao.FlatStyle = FlatStyle.Flat;
            btnEditarRazao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarRazao.ForeColor = SystemColors.ControlLightLight;
            btnEditarRazao.Image = (Image)resources.GetObject("btnEditarRazao.Image");
            btnEditarRazao.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarRazao.Location = new Point(0, 140);
            btnEditarRazao.Name = "btnEditarRazao";
            btnEditarRazao.Size = new Size(240, 70);
            btnEditarRazao.TabIndex = 48;
            btnEditarRazao.Text = "            Editar";
            btnEditarRazao.UseVisualStyleBackColor = false;
            // 
            // btnNovaRazao
            // 
            btnNovaRazao.BackColor = Color.FromArgb(69, 71, 106);
            btnNovaRazao.FlatAppearance.BorderSize = 0;
            btnNovaRazao.FlatStyle = FlatStyle.Flat;
            btnNovaRazao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovaRazao.ForeColor = SystemColors.ControlLightLight;
            btnNovaRazao.Image = (Image)resources.GetObject("btnNovaRazao.Image");
            btnNovaRazao.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovaRazao.Location = new Point(0, 70);
            btnNovaRazao.Name = "btnNovaRazao";
            btnNovaRazao.Size = new Size(240, 70);
            btnNovaRazao.TabIndex = 47;
            btnNovaRazao.Text = "            Nova";
            btnNovaRazao.UseVisualStyleBackColor = false;
            // 
            // btnRazoes
            // 
            btnRazoes.BackColor = Color.FromArgb(50, 52, 77);
            btnRazoes.FlatAppearance.BorderSize = 0;
            btnRazoes.FlatStyle = FlatStyle.Flat;
            btnRazoes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRazoes.ForeColor = SystemColors.ControlLightLight;
            btnRazoes.Image = (Image)resources.GetObject("btnRazoes.Image");
            btnRazoes.ImageAlign = ContentAlignment.MiddleLeft;
            btnRazoes.Location = new Point(0, 0);
            btnRazoes.Name = "btnRazoes";
            btnRazoes.Size = new Size(240, 70);
            btnRazoes.TabIndex = 46;
            btnRazoes.Text = "            Razões";
            btnRazoes.UseVisualStyleBackColor = false;
            btnRazoes.Click += btnRazoes_Click;
            // 
            // painelDgv
            // 
            painelDgv.BackColor = Color.FromArgb(128, 255, 128);
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
            flowLayoutPanel1.ResumeLayout(false);
            pnlVer.ResumeLayout(false);
            pnlClientes.ResumeLayout(false);
            pnlRazoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private Label label1;
        private Panel upperPanel;
        private System.Windows.Forms.Timer timerVer;
        private System.Windows.Forms.Timer timerClientes;
        private System.Windows.Forms.Timer timerRazoes;
        private System.Windows.Forms.Timer timerView;
        private Panel pnlUpperControls;
        private Panel pnlLogo;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlVer;
        private Button btnVerRazões;
        private Button btnVerConsultas;
        private Button btnVer;
        private Button btnVerClientes;
        private Panel pnlClientes;
        private Button btnExcluirCliente;
        private Button btnNovoCliente;
        private Button btnEditarCliente;
        private Button btnClientes;
        private Panel pnlRazoes;
        private Button btnExcluirRazao;
        private Button btnEditarRazao;
        private Button btnNovaRazao;
        private Button btnRazoes;
        private Panel painelDgv;
    }
}
