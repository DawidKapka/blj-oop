namespace A05
{
    partial class Form1
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
            this.resultBox = new System.Windows.Forms.TextBox();
            this.cHeightBox = new System.Windows.Forms.TextBox();
            this.tHeightBox = new System.Windows.Forms.TextBox();
            this.tWidthBox = new System.Windows.Forms.TextBox();
            this.trunkWidth = new System.Windows.Forms.Label();
            this.trunkHeight = new System.Windows.Forms.Label();
            this.crownHeight = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.resultBox.Location = new System.Drawing.Point(12, 162);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(307, 276);
            this.resultBox.TabIndex = 0;
            // 
            // cHeightBox
            // 
            this.cHeightBox.Location = new System.Drawing.Point(85, 122);
            this.cHeightBox.Name = "cHeightBox";
            this.cHeightBox.Size = new System.Drawing.Size(102, 20);
            this.cHeightBox.TabIndex = 1;
            this.cHeightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cHeightBox_KeyPress);
            // 
            // tHeightBox
            // 
            this.tHeightBox.Location = new System.Drawing.Point(85, 80);
            this.tHeightBox.Name = "tHeightBox";
            this.tHeightBox.Size = new System.Drawing.Size(102, 20);
            this.tHeightBox.TabIndex = 2;
            this.tHeightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tHeightBox_KeyPress);
            // 
            // tWidthBox
            // 
            this.tWidthBox.Location = new System.Drawing.Point(85, 38);
            this.tWidthBox.Name = "tWidthBox";
            this.tWidthBox.Size = new System.Drawing.Size(102, 20);
            this.tWidthBox.TabIndex = 3;
            this.tWidthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tWidthBox_KeyPress);
            // 
            // trunkWidth
            // 
            this.trunkWidth.AutoSize = true;
            this.trunkWidth.Location = new System.Drawing.Point(14, 41);
            this.trunkWidth.Name = "trunkWidth";
            this.trunkWidth.Size = new System.Drawing.Size(65, 13);
            this.trunkWidth.TabIndex = 4;
            this.trunkWidth.Text = "Stammbreite";
            // 
            // trunkHeight
            // 
            this.trunkHeight.AutoSize = true;
            this.trunkHeight.Location = new System.Drawing.Point(14, 83);
            this.trunkHeight.Name = "trunkHeight";
            this.trunkHeight.Size = new System.Drawing.Size(63, 13);
            this.trunkHeight.TabIndex = 5;
            this.trunkHeight.Text = "Stammhöhe";
            // 
            // crownHeight
            // 
            this.crownHeight.AutoSize = true;
            this.crownHeight.Location = new System.Drawing.Point(12, 125);
            this.crownHeight.Name = "crownHeight";
            this.crownHeight.Size = new System.Drawing.Size(65, 13);
            this.crownHeight.TabIndex = 6;
            this.crownHeight.Text = "Kronenhöhe";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(211, 117);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(108, 28);
            this.drawButton.TabIndex = 7;
            this.drawButton.Text = "Tanne zeichnen";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 450);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.crownHeight);
            this.Controls.Add(this.trunkHeight);
            this.Controls.Add(this.trunkWidth);
            this.Controls.Add(this.tWidthBox);
            this.Controls.Add(this.tHeightBox);
            this.Controls.Add(this.cHeightBox);
            this.Controls.Add(this.resultBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox cHeightBox;
        private System.Windows.Forms.TextBox tHeightBox;
        private System.Windows.Forms.TextBox tWidthBox;
        private System.Windows.Forms.Label trunkWidth;
        private System.Windows.Forms.Label trunkHeight;
        private System.Windows.Forms.Label crownHeight;
        private System.Windows.Forms.Button drawButton;
    }
}

