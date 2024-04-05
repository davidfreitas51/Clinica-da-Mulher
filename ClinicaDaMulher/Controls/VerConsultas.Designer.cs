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
            panel3 = new Panel();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            painelLegal = new Panel();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            painelLegal.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(685, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(162, 84);
            panel3.TabIndex = 41;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(167, 38, 135);
            button1.Location = new Point(3, 31);
            button1.Name = "button1";
            button1.Size = new Size(46, 46);
            button1.TabIndex = 21;
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(167, 38, 135);
            button3.Location = new Point(55, 31);
            button3.Name = "button3";
            button3.Size = new Size(46, 46);
            button3.TabIndex = 23;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(167, 38, 135);
            button2.Location = new Point(107, 31);
            button2.Name = "button2";
            button2.Size = new Size(46, 46);
            button2.TabIndex = 22;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(358, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 30);
            comboBox1.TabIndex = 43;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(183, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 31);
            textBox2.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(358, 11);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 44;
            label4.Text = "Razão";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(181, 12);
            label2.Name = "label2";
            label2.Size = new Size(162, 28);
            label2.TabIndex = 42;
            label2.Text = "Dia selecionado";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(17, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 31);
            textBox1.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(17, 10);
            label3.Name = "label3";
            label3.Size = new Size(132, 28);
            label3.TabIndex = 46;
            label3.Text = "Cliente (CPF)";
            // 
            // panel1
            // 
            panel1.Controls.Add(painelLegal);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 84);
            panel1.TabIndex = 48;
            // 
            // painelLegal
            // 
            painelLegal.Controls.Add(textBox1);
            painelLegal.Controls.Add(label2);
            painelLegal.Controls.Add(textBox2);
            painelLegal.Controls.Add(label3);
            painelLegal.Controls.Add(label4);
            painelLegal.Controls.Add(comboBox1);
            painelLegal.Dock = DockStyle.Fill;
            painelLegal.Location = new Point(0, 0);
            painelLegal.Name = "painelLegal";
            painelLegal.Size = new Size(847, 84);
            painelLegal.TabIndex = 0;
            // 
            // VerConsultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(167, 38, 135);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "VerConsultas";
            Size = new Size(847, 84);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            painelLegal.ResumeLayout(false);
            painelLegal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button button1;
        private Button button3;
        private Button button2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Panel panel1;
        private Panel painelLegal;
    }
}
