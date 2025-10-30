namespace windowsFormOI
{
    partial class PagGirar
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.c270Box = new System.Windows.Forms.CheckBox();
            this.c180Box = new System.Windows.Forms.CheckBox();
            this.c90Box = new System.Windows.Forms.CheckBox();
            this.AntiBox = new System.Windows.Forms.CheckBox();
            this.HorBox = new System.Windows.Forms.CheckBox();
            this.todasBox = new System.Windows.Forms.CheckBox();
            this.numerBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // c270Box
            // 
            this.c270Box.AutoSize = true;
            this.c270Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c270Box.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c270Box.Location = new System.Drawing.Point(188, 87);
            this.c270Box.Name = "c270Box";
            this.c270Box.Size = new System.Drawing.Size(49, 20);
            this.c270Box.TabIndex = 22;
            this.c270Box.Text = "270°";
            this.c270Box.UseVisualStyleBackColor = true;
            this.c270Box.CheckedChanged += new System.EventHandler(this.c270Box_CheckedChanged);
            // 
            // c180Box
            // 
            this.c180Box.AutoSize = true;
            this.c180Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c180Box.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c180Box.Location = new System.Drawing.Point(116, 87);
            this.c180Box.Name = "c180Box";
            this.c180Box.Size = new System.Drawing.Size(49, 20);
            this.c180Box.TabIndex = 21;
            this.c180Box.Text = "180°";
            this.c180Box.UseVisualStyleBackColor = true;
            this.c180Box.CheckedChanged += new System.EventHandler(this.c180Box_CheckedChanged);
            // 
            // c90Box
            // 
            this.c90Box.AutoSize = true;
            this.c90Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c90Box.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c90Box.Location = new System.Drawing.Point(52, 87);
            this.c90Box.Name = "c90Box";
            this.c90Box.Size = new System.Drawing.Size(43, 20);
            this.c90Box.TabIndex = 20;
            this.c90Box.Text = "90°";
            this.c90Box.UseVisualStyleBackColor = true;
            this.c90Box.CheckedChanged += new System.EventHandler(this.c90Box_CheckedChanged);
            // 
            // AntiBox
            // 
            this.AntiBox.AutoSize = true;
            this.AntiBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AntiBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AntiBox.Location = new System.Drawing.Point(204, 47);
            this.AntiBox.Name = "AntiBox";
            this.AntiBox.Size = new System.Drawing.Size(90, 20);
            this.AntiBox.TabIndex = 19;
            this.AntiBox.Text = "Anti-Horário";
            this.AntiBox.UseVisualStyleBackColor = true;
            this.AntiBox.CheckedChanged += new System.EventHandler(this.AntiBox_CheckedChanged);
            // 
            // HorBox
            // 
            this.HorBox.AutoSize = true;
            this.HorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HorBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorBox.Location = new System.Drawing.Point(116, 47);
            this.HorBox.Name = "HorBox";
            this.HorBox.Size = new System.Drawing.Size(65, 20);
            this.HorBox.TabIndex = 18;
            this.HorBox.Text = "Horário";
            this.HorBox.UseVisualStyleBackColor = true;
            this.HorBox.CheckedChanged += new System.EventHandler(this.HorBox_CheckedChanged);
            // 
            // todasBox
            // 
            this.todasBox.AutoSize = true;
            this.todasBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.todasBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todasBox.Location = new System.Drawing.Point(12, 47);
            this.todasBox.Name = "todasBox";
            this.todasBox.Size = new System.Drawing.Size(84, 20);
            this.todasBox.TabIndex = 17;
            this.todasBox.Text = "Todas Pág.";
            this.todasBox.UseVisualStyleBackColor = true;
            this.todasBox.CheckedChanged += new System.EventHandler(this.todasBox_CheckedChanged);
            // 
            // numerBox
            // 
            this.numerBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerBox.Location = new System.Drawing.Point(95, 129);
            this.numerBox.Name = "numerBox";
            this.numerBox.Size = new System.Drawing.Size(30, 25);
            this.numerBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(28, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Página:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(153, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 32);
            this.button1.TabIndex = 25;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PagGirar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.c270Box);
            this.Controls.Add(this.c180Box);
            this.Controls.Add(this.c90Box);
            this.Controls.Add(this.AntiBox);
            this.Controls.Add(this.HorBox);
            this.Controls.Add(this.todasBox);
            this.Name = "PagGirar";
            this.Size = new System.Drawing.Size(297, 197);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox c270Box;
        private System.Windows.Forms.CheckBox c180Box;
        private System.Windows.Forms.CheckBox c90Box;
        private System.Windows.Forms.CheckBox AntiBox;
        private System.Windows.Forms.CheckBox HorBox;
        private System.Windows.Forms.CheckBox todasBox;
        private System.Windows.Forms.TextBox numerBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
