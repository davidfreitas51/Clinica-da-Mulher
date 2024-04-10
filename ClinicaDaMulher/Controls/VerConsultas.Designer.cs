namespace ClinicaDaMulher.Controls
{
    partial class VerConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerConsultas));
            label4 = new Label();
            cbxMotivo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            pnlControlesConsultas = new Panel();
            btnLimpar = new Button();
            panel1 = new Panel();
            btnBuscar = new Button();
            txtCpf = new TextBox();
            mtxDia = new MaskedTextBox();
            txtNome = new TextBox();
            label1 = new Label();
            painelLegal = new Panel();
            btnExcluirConsulta = new Button();
            btnNovaConsulta = new Button();
            btnEditarConsulta = new Button();
            pnlControlesConsultas.SuspendLayout();
            panel1.SuspendLayout();
            painelLegal.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(656, 12);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 44;
            label4.Text = "Motivo";
            // 
            // cbxMotivo
            // 
            cbxMotivo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxMotivo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxMotivo.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbxMotivo.FormattingEnabled = true;
            cbxMotivo.Location = new Point(656, 43);
            cbxMotivo.Name = "cbxMotivo";
            cbxMotivo.Size = new Size(151, 28);
            cbxMotivo.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(513, 9);
            label2.Name = "label2";
            label2.Size = new Size(44, 28);
            label2.TabIndex = 42;
            label2.Text = "Dia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(344, 10);
            label3.Name = "label3";
            label3.Size = new Size(132, 28);
            label3.TabIndex = 46;
            label3.Text = "Cliente (CPF)";
            // 
            // pnlControlesConsultas
            // 
            pnlControlesConsultas.Controls.Add(btnLimpar);
            pnlControlesConsultas.Controls.Add(panel1);
            pnlControlesConsultas.Controls.Add(txtCpf);
            pnlControlesConsultas.Controls.Add(mtxDia);
            pnlControlesConsultas.Controls.Add(txtNome);
            pnlControlesConsultas.Controls.Add(label1);
            pnlControlesConsultas.Controls.Add(painelLegal);
            pnlControlesConsultas.Controls.Add(label3);
            pnlControlesConsultas.Controls.Add(label2);
            pnlControlesConsultas.Controls.Add(label4);
            pnlControlesConsultas.Controls.Add(cbxMotivo);
            pnlControlesConsultas.Dock = DockStyle.Fill;
            pnlControlesConsultas.Font = new Font("Microsoft Sans Serif", 10.2F);
            pnlControlesConsultas.Location = new Point(0, 0);
            pnlControlesConsultas.Name = "pnlControlesConsultas";
            pnlControlesConsultas.Size = new Size(1398, 84);
            pnlControlesConsultas.TabIndex = 48;
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
            // panel1
            // 
            panel1.Controls.Add(btnBuscar);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1035, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(106, 84);
            panel1.TabIndex = 57;
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(167, 38, 135);
            btnBuscar.Location = new Point(3, 11);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(64, 64);
            btnBuscar.TabIndex = 52;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtCpf.Location = new Point(351, 44);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(125, 27);
            txtCpf.TabIndex = 56;
            // 
            // mtxDia
            // 
            mtxDia.Font = new Font("Microsoft Sans Serif", 10.2F);
            mtxDia.Location = new Point(513, 44);
            mtxDia.Mask = "00/00/0000";
            mtxDia.Name = "mtxDia";
            mtxDia.Size = new Size(95, 27);
            mtxDia.TabIndex = 55;
            mtxDia.ValidatingType = typeof(DateTime);
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtNome.Location = new Point(136, 39);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(184, 27);
            txtNome.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(139, 13);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 53;
            label1.Text = "Nome";
            // 
            // painelLegal
            // 
            painelLegal.Controls.Add(btnExcluirConsulta);
            painelLegal.Controls.Add(btnNovaConsulta);
            painelLegal.Controls.Add(btnEditarConsulta);
            painelLegal.Dock = DockStyle.Right;
            painelLegal.Location = new Point(1141, 0);
            painelLegal.Name = "painelLegal";
            painelLegal.Size = new Size(257, 84);
            painelLegal.TabIndex = 48;
            // 
            // btnExcluirConsulta
            // 
            btnExcluirConsulta.BackgroundImage = (Image)resources.GetObject("btnExcluirConsulta.BackgroundImage");
            btnExcluirConsulta.BackgroundImageLayout = ImageLayout.Stretch;
            btnExcluirConsulta.FlatStyle = FlatStyle.Flat;
            btnExcluirConsulta.ForeColor = Color.FromArgb(167, 38, 135);
            btnExcluirConsulta.Location = new Point(176, 7);
            btnExcluirConsulta.Name = "btnExcluirConsulta";
            btnExcluirConsulta.Size = new Size(70, 70);
            btnExcluirConsulta.TabIndex = 22;
            btnExcluirConsulta.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluirConsulta.UseVisualStyleBackColor = true;
            btnExcluirConsulta.Click += btnExcluirConsulta_Click;
            // 
            // btnNovaConsulta
            // 
            btnNovaConsulta.BackgroundImage = (Image)resources.GetObject("btnNovaConsulta.BackgroundImage");
            btnNovaConsulta.BackgroundImageLayout = ImageLayout.Stretch;
            btnNovaConsulta.FlatStyle = FlatStyle.Flat;
            btnNovaConsulta.ForeColor = Color.FromArgb(167, 38, 135);
            btnNovaConsulta.Location = new Point(24, 7);
            btnNovaConsulta.Name = "btnNovaConsulta";
            btnNovaConsulta.Size = new Size(70, 70);
            btnNovaConsulta.TabIndex = 21;
            btnNovaConsulta.UseVisualStyleBackColor = true;
            btnNovaConsulta.Click += btnNovaConsulta_Click;
            // 
            // btnEditarConsulta
            // 
            btnEditarConsulta.BackgroundImage = (Image)resources.GetObject("btnEditarConsulta.BackgroundImage");
            btnEditarConsulta.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditarConsulta.FlatStyle = FlatStyle.Flat;
            btnEditarConsulta.ForeColor = Color.FromArgb(167, 38, 135);
            btnEditarConsulta.Location = new Point(100, 8);
            btnEditarConsulta.Name = "btnEditarConsulta";
            btnEditarConsulta.Size = new Size(70, 70);
            btnEditarConsulta.TabIndex = 23;
            btnEditarConsulta.UseVisualStyleBackColor = true;
            btnEditarConsulta.Click += btnEditarConsulta_Click;
            // 
            // VerConsultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(167, 38, 135);
            Controls.Add(pnlControlesConsultas);
            Name = "VerConsultas";
            Size = new Size(1398, 84);
            Load += VerConsultas_Load;
            pnlControlesConsultas.ResumeLayout(false);
            pnlControlesConsultas.PerformLayout();
            panel1.ResumeLayout(false);
            painelLegal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private Label label2;
        private Label label3;
        private Panel pnlControlesConsultas;
        private Button btnNovaConsulta;
        private Button btnEditarConsulta;
        private Button btnExcluirConsulta;
        private Panel painelLegal;
        private Button btnBuscar;
        private TextBox txtNome;
        private Label label1;
        private MaskedTextBox mtxDia;
        private TextBox txtCpf;
        public ComboBox cbxMotivo;
        private Panel panel1;
        private Button btnLimpar;
    }
}
