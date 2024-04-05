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
            pictureBox2 = new PictureBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            pnlClientes = new Panel();
            button13 = new Button();
            button15 = new Button();
            button14 = new Button();
            btnClientes = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            timerVer = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlVer = new Panel();
            btnVer = new Button();
            pnlRazoes = new Panel();
            btnRazoes = new Button();
            timerClientes = new System.Windows.Forms.Timer(components);
            timerRazoes = new System.Windows.Forms.Timer(components);
            timerView = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlClientes.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            label5.Location = new Point(68, 36);
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
            label1.Location = new Point(7, 3);
            label1.Name = "label1";
            label1.Size = new Size(155, 41);
            label1.TabIndex = 34;
            label1.Text = "Clínica da";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(137, 31, 110);
            pictureBox2.Location = new Point(-2, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(195, 78);
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(541, 7);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 30;
            label4.Text = "Razão";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(541, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 30);
            comboBox1.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(195, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 31);
            textBox1.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(195, 9);
            label3.Name = "label3";
            label3.Size = new Size(132, 28);
            label3.TabIndex = 26;
            label3.Text = "Cliente (CPF)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(364, 8);
            label2.Name = "label2";
            label2.Size = new Size(162, 28);
            label2.TabIndex = 24;
            label2.Text = "Dia selecionado";
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1221, 720);
            dataGridView1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(366, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 31);
            textBox2.TabIndex = 40;
            // 
            // pnlClientes
            // 
            pnlClientes.BackColor = Color.White;
            pnlClientes.Controls.Add(button13);
            pnlClientes.Controls.Add(button15);
            pnlClientes.Controls.Add(button14);
            pnlClientes.Controls.Add(btnClientes);
            pnlClientes.Location = new Point(3, 79);
            pnlClientes.MaximumSize = new Size(195, 280);
            pnlClientes.MinimumSize = new Size(195, 70);
            pnlClientes.Name = "pnlClientes";
            pnlClientes.Size = new Size(195, 71);
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
            button13.Size = new Size(198, 70);
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
            button15.Size = new Size(198, 70);
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
            button14.Size = new Size(198, 70);
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
            btnClientes.Location = new Point(14, 0);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(195, 70);
            btnClientes.TabIndex = 46;
            btnClientes.Text = "            Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += button12_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1221, 77);
            panel2.TabIndex = 44;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1059, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(162, 77);
            panel3.TabIndex = 0;
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
            flowLayoutPanel1.Size = new Size(198, 720);
            flowLayoutPanel1.TabIndex = 45;
            // 
            // pnlVer
            // 
            pnlVer.BackColor = Color.White;
            pnlVer.Controls.Add(btnVer);
            pnlVer.Location = new Point(3, 3);
            pnlVer.MaximumSize = new Size(195, 280);
            pnlVer.MinimumSize = new Size(195, 70);
            pnlVer.Name = "pnlVer";
            pnlVer.Size = new Size(195, 70);
            pnlVer.TabIndex = 48;
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
            btnVer.Location = new Point(16, 1);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(195, 68);
            btnVer.TabIndex = 47;
            btnVer.Text = "            Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += button4_Click;
            // 
            // pnlRazoes
            // 
            pnlRazoes.BackColor = Color.White;
            pnlRazoes.Controls.Add(btnRazoes);
            pnlRazoes.Location = new Point(3, 156);
            pnlRazoes.MaximumSize = new Size(195, 280);
            pnlRazoes.MinimumSize = new Size(195, 70);
            pnlRazoes.Name = "pnlRazoes";
            pnlRazoes.Size = new Size(195, 70);
            pnlRazoes.TabIndex = 47;
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
            btnRazoes.Location = new Point(7, -1);
            btnRazoes.Name = "btnRazoes";
            btnRazoes.Size = new Size(195, 71);
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
            ClientSize = new Size(1221, 797);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clínica da Mulher";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlClientes.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            pnlVer.ResumeLayout(false);
            pnlRazoes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Panel panel2;
        private Panel panel3;
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
    }
}
