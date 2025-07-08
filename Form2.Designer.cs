namespace windowsFormOI
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.BtnAbri = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c270Box = new System.Windows.Forms.CheckBox();
            this.c180Box = new System.Windows.Forms.CheckBox();
            this.c90Box = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.AntiBox = new System.Windows.Forms.CheckBox();
            this.HorBox = new System.Windows.Forms.CheckBox();
            this.todasBox = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.numerBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAbri
            // 
            this.BtnAbri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(196)))));
            this.BtnAbri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAbri.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbri.Location = new System.Drawing.Point(48, 16);
            this.BtnAbri.Name = "BtnAbri";
            this.BtnAbri.Size = new System.Drawing.Size(192, 40);
            this.BtnAbri.TabIndex = 1;
            this.BtnAbri.Text = "Buscar Arquivo";
            this.BtnAbri.UseVisualStyleBackColor = false;
            this.BtnAbri.Click += new System.EventHandler(this.BtnAbri_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1084, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(392, 16);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(672, 704);
            this.webBrowser1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.c270Box);
            this.panel1.Controls.Add(this.c180Box);
            this.panel1.Controls.Add(this.c90Box);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.AntiBox);
            this.panel1.Controls.Add(this.HorBox);
            this.panel1.Controls.Add(this.todasBox);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.numerBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtnAbri);
            this.panel1.Location = new System.Drawing.Point(48, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 368);
            this.panel1.TabIndex = 4;
            // 
            // c270Box
            // 
            this.c270Box.AutoSize = true;
            this.c270Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c270Box.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c270Box.Location = new System.Drawing.Point(184, 336);
            this.c270Box.Name = "c270Box";
            this.c270Box.Size = new System.Drawing.Size(49, 20);
            this.c270Box.TabIndex = 16;
            this.c270Box.Text = "270°";
            this.c270Box.UseVisualStyleBackColor = true;
            this.c270Box.CheckedChanged += new System.EventHandler(this.c270Box_CheckedChanged);
            // 
            // c180Box
            // 
            this.c180Box.AutoSize = true;
            this.c180Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c180Box.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c180Box.Location = new System.Drawing.Point(112, 336);
            this.c180Box.Name = "c180Box";
            this.c180Box.Size = new System.Drawing.Size(49, 20);
            this.c180Box.TabIndex = 15;
            this.c180Box.Text = "180°";
            this.c180Box.UseVisualStyleBackColor = true;
            this.c180Box.CheckedChanged += new System.EventHandler(this.c180Box_CheckedChanged);
            // 
            // c90Box
            // 
            this.c90Box.AutoSize = true;
            this.c90Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c90Box.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c90Box.Location = new System.Drawing.Point(48, 336);
            this.c90Box.Name = "c90Box";
            this.c90Box.Size = new System.Drawing.Size(43, 20);
            this.c90Box.TabIndex = 14;
            this.c90Box.Text = "90°";
            this.c90Box.UseVisualStyleBackColor = true;
            this.c90Box.CheckedChanged += new System.EventHandler(this.c90Box_CheckedChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(196)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(80, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 32);
            this.button4.TabIndex = 13;
            this.button4.Text = "Girar Página";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AntiBox
            // 
            this.AntiBox.AutoSize = true;
            this.AntiBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AntiBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AntiBox.Location = new System.Drawing.Point(200, 296);
            this.AntiBox.Name = "AntiBox";
            this.AntiBox.Size = new System.Drawing.Size(90, 20);
            this.AntiBox.TabIndex = 12;
            this.AntiBox.Text = "Anti-Horário";
            this.AntiBox.UseVisualStyleBackColor = true;
            this.AntiBox.CheckedChanged += new System.EventHandler(this.AntiBox_CheckedChanged);
            // 
            // HorBox
            // 
            this.HorBox.AutoSize = true;
            this.HorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HorBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorBox.Location = new System.Drawing.Point(112, 296);
            this.HorBox.Name = "HorBox";
            this.HorBox.Size = new System.Drawing.Size(65, 20);
            this.HorBox.TabIndex = 11;
            this.HorBox.Text = "Horário";
            this.HorBox.UseVisualStyleBackColor = true;
            this.HorBox.CheckedChanged += new System.EventHandler(this.HorBox_CheckedChanged);
            // 
            // todasBox
            // 
            this.todasBox.AutoSize = true;
            this.todasBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.todasBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todasBox.Location = new System.Drawing.Point(8, 296);
            this.todasBox.Name = "todasBox";
            this.todasBox.Size = new System.Drawing.Size(84, 20);
            this.todasBox.TabIndex = 10;
            this.todasBox.Text = "Todas Pág.";
            this.todasBox.UseVisualStyleBackColor = true;
            this.todasBox.CheckedChanged += new System.EventHandler(this.todasBox_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(216, 120);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 20);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Depois";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(16, 120);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 20);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Antes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(196)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(80, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "Extrair Página";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numerBox
            // 
            this.numerBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerBox.Location = new System.Drawing.Point(188, 68);
            this.numerBox.Name = "numerBox";
            this.numerBox.Size = new System.Drawing.Size(32, 26);
            this.numerBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número Pag.";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(196)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(80, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remover Página";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(196)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(80, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adicionar Página";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "PDF Tools";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(328, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Help";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAbri;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox numerBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox c180Box;
        private System.Windows.Forms.CheckBox c90Box;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox AntiBox;
        private System.Windows.Forms.CheckBox HorBox;
        private System.Windows.Forms.CheckBox todasBox;
        private System.Windows.Forms.CheckBox c270Box;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}