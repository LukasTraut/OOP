namespace HelloForm
{
    partial class Rechteck
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.height = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.GetArea = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(272, 125);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(226, 26);
            this.height.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Berechnen ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Breite des Rechtecks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Höhe des Rechtecks";
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(272, 188);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(226, 26);
            this.width.TabIndex = 4;
            // 
            // GetArea
            // 
            this.GetArea.AutoSize = true;
            this.GetArea.Location = new System.Drawing.Point(66, 315);
            this.GetArea.Name = "GetArea";
            this.GetArea.Size = new System.Drawing.Size(135, 20);
            this.GetArea.TabIndex = 5;
            this.GetArea.Text = "Ausgabe (Fläche)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Beenden";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "0";
            // 
            // Rechteck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 499);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GetArea);
            this.Controls.Add(this.width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.height);
            this.Name = "Rechteck";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.Label GetArea;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}

