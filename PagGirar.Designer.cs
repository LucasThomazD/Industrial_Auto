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
            this.SuspendLayout();
            // 
            // c270Box
            // 
            this.c270Box.AutoSize = true;
            this.c270Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c270Box.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c270Box.Location = new System.Drawing.Point(188, 132);
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
            this.c180Box.Location = new System.Drawing.Point(116, 132);
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
            this.c90Box.Location = new System.Drawing.Point(52, 132);
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
            this.AntiBox.Location = new System.Drawing.Point(204, 92);
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
            this.HorBox.Location = new System.Drawing.Point(116, 92);
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
            this.todasBox.Location = new System.Drawing.Point(12, 92);
            this.todasBox.Name = "todasBox";
            this.todasBox.Size = new System.Drawing.Size(84, 20);
            this.todasBox.TabIndex = 17;
            this.todasBox.Text = "Todas Pág.";
            this.todasBox.UseVisualStyleBackColor = true;
            this.todasBox.CheckedChanged += new System.EventHandler(this.todasBox_CheckedChanged);
            // 
            // PagGirar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
