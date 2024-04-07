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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnNovoMotivo = new Button();
            txtMotivo = new TextBox();
            label3 = new Label();
            btnBuscar = new Button();
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
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnNovoMotivo);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(565, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 84);
            panel1.TabIndex = 54;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(69, 71, 106);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(196, 8);
            button2.Name = "button2";
            button2.Size = new Size(70, 70);
            button2.TabIndex = 50;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(69, 71, 106);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(106, 7);
            button1.Name = "button1";
            button1.Size = new Size(70, 70);
            button1.TabIndex = 49;
            button1.UseVisualStyleBackColor = false;
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
        private Button button2;
        private Button button1;
        private Button btnNovoMotivo;
        private Button btnBuscar;
    }
}
