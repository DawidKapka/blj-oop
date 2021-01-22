namespace A06
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.getAllButton = new System.Windows.Forms.Button();
            this.getButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.putButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.putBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.getAllButton);
            this.groupBox1.Controls.Add(this.getButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.resultBox);
            this.groupBox1.Controls.Add(this.putButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.putBox);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sizeBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FIFO Puffer testen";
            // 
            // getAllButton
            // 
            this.getAllButton.Enabled = false;
            this.getAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllButton.Location = new System.Drawing.Point(9, 218);
            this.getAllButton.Name = "getAllButton";
            this.getAllButton.Size = new System.Drawing.Size(86, 28);
            this.getAllButton.TabIndex = 9;
            this.getAllButton.Text = "GetAll";
            this.getAllButton.UseVisualStyleBackColor = true;
            this.getAllButton.Click += new System.EventHandler(this.getAllButton_Click);
            // 
            // getButton
            // 
            this.getButton.Enabled = false;
            this.getButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getButton.Location = new System.Drawing.Point(9, 184);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(86, 28);
            this.getButton.TabIndex = 8;
            this.getButton.Text = "Get";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ausgabe";
            // 
            // resultBox
            // 
            this.resultBox.Enabled = false;
            this.resultBox.Location = new System.Drawing.Point(155, 207);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(86, 20);
            this.resultBox.TabIndex = 6;
            // 
            // putButton
            // 
            this.putButton.Enabled = false;
            this.putButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.putButton.Location = new System.Drawing.Point(155, 115);
            this.putButton.Name = "putButton";
            this.putButton.Size = new System.Drawing.Size(86, 28);
            this.putButton.TabIndex = 5;
            this.putButton.Text = "Put";
            this.putButton.UseVisualStyleBackColor = true;
            this.putButton.Click += new System.EventHandler(this.putButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Eingabe";
            // 
            // putBox
            // 
            this.putBox.Enabled = false;
            this.putBox.Location = new System.Drawing.Point(78, 120);
            this.putBox.Name = "putBox";
            this.putBox.Size = new System.Drawing.Size(59, 20);
            this.putBox.TabIndex = 3;
            this.putBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.putBox_KeyPress);
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(155, 36);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(86, 28);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Puffer erstellen";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puffergrösse";
            // 
            // sizeBox
            // 
            this.sizeBox.Location = new System.Drawing.Point(78, 41);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(59, 20);
            this.sizeBox.TabIndex = 0;
            this.sizeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sizeBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 296);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button getAllButton;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button putButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox putBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sizeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

