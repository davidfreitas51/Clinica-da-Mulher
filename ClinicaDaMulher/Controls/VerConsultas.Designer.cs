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
            txtCpf = new TextBox();
            mtxDia = new MaskedTextBox();
            txtNome = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            painelLegal = new Panel();
            btnExcluirConsulta = new Button();
            btnNovaConsulta = new Button();
            btnEditarConsulta = new Button();
            pnlControlesConsultas.SuspendLayout();
            painelLegal.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(597, 11);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 44;
            label4.Text = "Motivo";
            // 
            // cbxMotivo
            // 
            cbxMotivo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxMotivo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxMotivo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxMotivo.FormattingEnabled = true;
            cbxMotivo.Location = new Point(597, 42);
            cbxMotivo.Name = "cbxMotivo";
            cbxMotivo.Size = new Size(151, 30);
            cbxMotivo.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(420, 10);
            label2.Name = "label2";
            label2.Size = new Size(162, 28);
            label2.TabIndex = 42;
            label2.Text = "Dia selecionado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(208, 10);
            label3.Name = "label3";
            label3.Size = new Size(132, 28);
            label3.TabIndex = 46;
            label3.Text = "Cliente (CPF)";
            // 
            // pnlControlesConsultas
            // 
            pnlControlesConsultas.Controls.Add(txtCpf);
            pnlControlesConsultas.Controls.Add(mtxDia);
            pnlControlesConsultas.Controls.Add(txtNome);
            pnlControlesConsultas.Controls.Add(label1);
            pnlControlesConsultas.Controls.Add(btnBuscar);
            pnlControlesConsultas.Controls.Add(painelLegal);
            pnlControlesConsultas.Controls.Add(label3);
            pnlControlesConsultas.Controls.Add(label2);
            pnlControlesConsultas.Controls.Add(label4);
            pnlControlesConsultas.Controls.Add(cbxMotivo);
            pnlControlesConsultas.Dock = DockStyle.Fill;
            pnlControlesConsultas.Location = new Point(0, 0);
            pnlControlesConsultas.Name = "pnlControlesConsultas";
            pnlControlesConsultas.Size = new Size(1111, 84);
            pnlControlesConsultas.TabIndex = 48;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(215, 44);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(125, 27);
            txtCpf.TabIndex = 56;
            // 
            // mtxDia
            // 
            mtxDia.Location = new Point(420, 45);
            mtxDia.Mask = "00/00/0000";
            mtxDia.Name = "mtxDia";
            mtxDia.Size = new Size(125, 27);
            mtxDia.TabIndex = 55;
            mtxDia.ValidatingType = typeof(DateTime);
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(19, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(153, 31);
            txtNome.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(19, 10);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 53;
            label1.Text = "Nome";
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(167, 38, 135);
            btnBuscar.Location = new Point(802, 29);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(46, 46);
            btnBuscar.TabIndex = 52;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // painelLegal
            // 
            painelLegal.Controls.Add(btnExcluirConsulta);
            painelLegal.Controls.Add(btnNovaConsulta);
            painelLegal.Controls.Add(btnEditarConsulta);
            painelLegal.Dock = DockStyle.Right;
            painelLegal.Location = new Point(929, 0);
            painelLegal.Name = "painelLegal";
            painelLegal.Size = new Size(182, 84);
            painelLegal.TabIndex = 48;
            // 
            // btnExcluirConsulta
            // 
            btnExcluirConsulta.BackgroundImage = (Image)resources.GetObject("btnExcluirConsulta.BackgroundImage");
            btnExcluirConsulta.BackgroundImageLayout = ImageLayout.Stretch;
            btnExcluirConsulta.FlatStyle = FlatStyle.Flat;
            btnExcluirConsulta.ForeColor = Color.FromArgb(167, 38, 135);
            btnExcluirConsulta.Location = new Point(120, 28);
            btnExcluirConsulta.Name = "btnExcluirConsulta";
            btnExcluirConsulta.Size = new Size(46, 46);
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
            btnNovaConsulta.Location = new Point(16, 28);
            btnNovaConsulta.Name = "btnNovaConsulta";
            btnNovaConsulta.Size = new Size(46, 46);
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
            btnEditarConsulta.Location = new Point(68, 28);
            btnEditarConsulta.Name = "btnEditarConsulta";
            btnEditarConsulta.Size = new Size(46, 46);
            btnEditarConsulta.TabIndex = 23;
            btnEditarConsulta.UseVisualStyleBackColor = true;
            // 
            // VerConsultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(167, 38, 135);
            Controls.Add(pnlControlesConsultas);
            Name = "VerConsultas";
            Size = new Size(1111, 84);
            Load += VerConsultas_Load;
            pnlControlesConsultas.ResumeLayout(false);
            pnlControlesConsultas.PerformLayout();
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
    }
}
