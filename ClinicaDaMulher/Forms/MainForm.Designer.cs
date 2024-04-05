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
            dgvPrincipal = new DataGridView();
            pnlClientes = new Panel();
            button13 = new Button();
            button15 = new Button();
            button14 = new Button();
            btnClientes = new Button();
            upperPanel = new Panel();
            pnlUpperControls = new Panel();
            label2 = new Label();
            pnlLogo = new Panel();
            timerVer = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlVer = new Panel();
            btnVerRazões = new Button();
            btnVerConsultas = new Button();
            btnVer = new Button();
            btnVerClientes = new Button();
            pnlRazoes = new Panel();
            button8 = new Button();
            button9 = new Button();
            button7 = new Button();
            btnRazoes = new Button();
            timerClientes = new System.Windows.Forms.Timer(components);
            timerRazoes = new System.Windows.Forms.Timer(components);
            timerView = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).BeginInit();
            pnlClientes.SuspendLayout();
            upperPanel.SuspendLayout();
            pnlUpperControls.SuspendLayout();
            pnlLogo.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlVer.SuspendLayout();
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
            // dgvPrincipal
            // 
            dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrincipal.Dock = DockStyle.Fill;
            dgvPrincipal.Location = new Point(0, 77);
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.RowHeadersWidth = 51;
            dgvPrincipal.Size = new Size(1221, 866);
            dgvPrincipal.TabIndex = 20;
            // 
            // pnlClientes
            // 
            pnlClientes.BackColor = Color.White;
            pnlClientes.Controls.Add(button13);
            pnlClientes.Controls.Add(button15);
            pnlClientes.Controls.Add(button14);
            pnlClientes.Controls.Add(btnClientes);
            pnlClientes.Location = new Point(3, 79);
            pnlClientes.MaximumSize = new Size(240, 280);
            pnlClientes.MinimumSize = new Size(240, 70);
            pnlClientes.Name = "pnlClientes";
            pnlClientes.Size = new Size(240, 70);
            pnlClientes.TabIndex = 45;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(69, 71, 106);
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.ForeColor = SystemColors.ControlLightLight;
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(0, 210);
            button13.Name = "button13";
            button13.Size = new Size(240, 70);
            button13.TabIndex = 46;
            button13.Text = "              Excluir";
            button13.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(69, 71, 106);
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.ForeColor = SystemColors.ControlLightLight;
            button15.Image = (Image)resources.GetObject("button15.Image");
            button15.ImageAlign = ContentAlignment.MiddleLeft;
            button15.Location = new Point(-2, 70);
            button15.Name = "button15";
            button15.Size = new Size(240, 70);
            button15.TabIndex = 46;
            button15.Text = "             Novo";
            button15.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(69, 71, 106);
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.ForeColor = SystemColors.ControlLightLight;
            button14.Image = (Image)resources.GetObject("button14.Image");
            button14.ImageAlign = ContentAlignment.MiddleLeft;
            button14.Location = new Point(0, 140);
            button14.Name = "button14";
            button14.Size = new Size(240, 70);
            button14.TabIndex = 47;
            button14.Text = "             Editar";
            button14.UseVisualStyleBackColor = false;
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
            // upperPanel
            // 
            upperPanel.Controls.Add(pnlUpperControls);
            upperPanel.Controls.Add(pnlLogo);
            upperPanel.Dock = DockStyle.Top;
            upperPanel.Location = new Point(0, 0);
            upperPanel.Name = "upperPanel";
            upperPanel.Size = new Size(1221, 77);
            upperPanel.TabIndex = 44;
            // 
            // pnlUpperControls
            // 
            pnlUpperControls.Controls.Add(label2);
            pnlUpperControls.Dock = DockStyle.Top;
            pnlUpperControls.Location = new Point(240, 0);
            pnlUpperControls.Name = "pnlUpperControls";
            pnlUpperControls.Size = new Size(981, 77);
            pnlUpperControls.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 30);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "label2";
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(50, 52, 77);
            flowLayoutPanel1.Controls.Add(pnlVer);
            flowLayoutPanel1.Controls.Add(pnlClientes);
            flowLayoutPanel1.Controls.Add(pnlRazoes);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 77);
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
            pnlVer.Size = new Size(240, 70);
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
            // pnlRazoes
            // 
            pnlRazoes.BackColor = Color.White;
            pnlRazoes.Controls.Add(button8);
            pnlRazoes.Controls.Add(button9);
            pnlRazoes.Controls.Add(button7);
            pnlRazoes.Controls.Add(btnRazoes);
            pnlRazoes.Location = new Point(3, 155);
            pnlRazoes.MaximumSize = new Size(240, 280);
            pnlRazoes.MinimumSize = new Size(240, 70);
            pnlRazoes.Name = "pnlRazoes";
            pnlRazoes.Size = new Size(240, 70);
            pnlRazoes.TabIndex = 47;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(69, 71, 106);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(0, 210);
            button8.Name = "button8";
            button8.Size = new Size(240, 70);
            button8.TabIndex = 49;
            button8.Text = "            Excluir";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(69, 71, 106);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(0, 140);
            button9.Name = "button9";
            button9.Size = new Size(240, 70);
            button9.TabIndex = 48;
            button9.Text = "            Editar";
            button9.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(69, 71, 106);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 70);
            button7.Name = "button7";
            button7.Size = new Size(240, 70);
            button7.TabIndex = 47;
            button7.Text = "            Nova";
            button7.UseVisualStyleBackColor = false;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(167, 38, 135);
            ClientSize = new Size(1221, 943);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dgvPrincipal);
            Controls.Add(upperPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clínica da Mulher";
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).EndInit();
            pnlClientes.ResumeLayout(false);
            upperPanel.ResumeLayout(false);
            pnlUpperControls.ResumeLayout(false);
            pnlUpperControls.PerformLayout();
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            pnlVer.ResumeLayout(false);
            pnlRazoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private Label label1;
        private DataGridView dgvPrincipal;
        private Panel upperPanel;
        private Panel pnlClientes;
        private Button btnClientes;
        private Button button15;
        private Button button14;
        private System.Windows.Forms.Timer timerVer;
        private Button button13;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnRazoes;
        private Panel pnlRazoes;
        private System.Windows.Forms.Timer timerClientes;
        private System.Windows.Forms.Timer timerRazoes;
        private Panel pnlVer;
        private Button btnVer;
        private System.Windows.Forms.Timer timerView;
        private Button btnVerRazões;
        private Button btnVerConsultas;
        private Button btnVerClientes;
        private Button button8;
        private Button button9;
        private Button button7;
        private Panel pnlUpperControls;
        private Panel pnlLogo;
        private Label label2;
    }
}
