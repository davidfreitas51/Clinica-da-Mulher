namespace ClinicaDaMulher.Controls
{
    partial class VerClientes
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
            painelLegal = new Panel();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            painelLegal.SuspendLayout();
            SuspendLayout();
            // 
            // painelLegal
            // 
            painelLegal.BackColor = Color.FromArgb(167, 38, 135);
            painelLegal.Controls.Add(textBox2);
            painelLegal.Controls.Add(label1);
            painelLegal.Controls.Add(textBox1);
            painelLegal.Controls.Add(label3);
            painelLegal.Dock = DockStyle.Fill;
            painelLegal.Location = new Point(0, 0);
            painelLegal.Name = "painelLegal";
            painelLegal.Size = new Size(847, 84);
            painelLegal.TabIndex = 1;
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
            label3.Size = new Size(46, 28);
            label3.TabIndex = 46;
            label3.Text = "CPF";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(209, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 31);
            textBox2.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(209, 10);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 48;
            label1.Text = "Nome";
            // 
            // VerClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(painelLegal);
            Name = "VerClientes";
            Size = new Size(847, 84);
            painelLegal.ResumeLayout(false);
            painelLegal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel painelLegal;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label1;
    }
}
