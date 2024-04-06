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
            textBox2 = new TextBox();
            cbxMotivo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            pnlControlesConsultas = new Panel();
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
            label4.Location = new Point(433, 4);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 44;
            label4.Text = "Motivo";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(210, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 31);
            textBox2.TabIndex = 45;
            // 
            // cbxMotivo
            // 
            cbxMotivo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxMotivo.FormattingEnabled = true;
            cbxMotivo.Location = new Point(433, 35);
            cbxMotivo.Name = "cbxMotivo";
            cbxMotivo.Size = new Size(151, 30);
            cbxMotivo.TabIndex = 43;
            cbxMotivo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(210, 4);
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
            label3.Location = new Point(35, 5);
            label3.Name = "label3";
            label3.Size = new Size(132, 28);
            label3.TabIndex = 46;
            label3.Text = "Cliente (CPF)";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(35, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 31);
            textBox1.TabIndex = 47;
            // 
            // pnlControlesConsultas
            // 
            pnlControlesConsultas.Controls.Add(painelLegal);
            pnlControlesConsultas.Controls.Add(textBox1);
            pnlControlesConsultas.Controls.Add(label3);
            pnlControlesConsultas.Controls.Add(textBox2);
            pnlControlesConsultas.Controls.Add(label2);
            pnlControlesConsultas.Controls.Add(label4);
            pnlControlesConsultas.Controls.Add(cbxMotivo);
            pnlControlesConsultas.Dock = DockStyle.Top;
            pnlControlesConsultas.Location = new Point(0, 0);
            pnlControlesConsultas.Name = "pnlControlesConsultas";
            pnlControlesConsultas.Size = new Size(847, 84);
            pnlControlesConsultas.TabIndex = 48;
            // 
            // painelLegal
            // 
            painelLegal.Controls.Add(btnExcluirConsulta);
            painelLegal.Controls.Add(btnNovaConsulta);
            painelLegal.Controls.Add(btnEditarConsulta);
            painelLegal.Dock = DockStyle.Right;
            painelLegal.Location = new Point(665, 0);
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
            Size = new Size(847, 84);
            pnlControlesConsultas.ResumeLayout(false);
            pnlControlesConsultas.PerformLayout();
            painelLegal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private TextBox textBox2;
        private ComboBox cbxMotivo;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Panel pnlControlesConsultas;
        private Button btnNovaConsulta;
        private Button btnEditarConsulta;
        private Button btnExcluirConsulta;
        private Panel painelLegal;
    }
}
