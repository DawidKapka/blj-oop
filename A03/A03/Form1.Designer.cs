namespace A03
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
            this.calcButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.TextBox();
            this.checkHours = new System.Windows.Forms.RadioButton();
            this.checkDays = new System.Windows.Forms.RadioButton();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calcButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.speed);
            this.groupBox1.Controls.Add(this.checkHours);
            this.groupBox1.Controls.Add(this.checkDays);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reisedauer zum Mond berechnen";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(18, 115);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(247, 23);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Reisedauer berechnen";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Geschwindigkeit km/h";
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(134, 85);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(131, 20);
            this.speed.TabIndex = 2;
            // 
            // checkHours
            // 
            this.checkHours.AutoSize = true;
            this.checkHours.Location = new System.Drawing.Point(120, 42);
            this.checkHours.Name = "checkHours";
            this.checkHours.Size = new System.Drawing.Size(76, 17);
            this.checkHours.TabIndex = 1;
            this.checkHours.TabStop = true;
            this.checkHours.Text = "in Stunden";
            this.checkHours.UseVisualStyleBackColor = true;
            // 
            // checkDays
            // 
            this.checkDays.AutoSize = true;
            this.checkDays.Location = new System.Drawing.Point(18, 42);
            this.checkDays.Name = "checkDays";
            this.checkDays.Size = new System.Drawing.Size(67, 17);
            this.checkDays.TabIndex = 0;
            this.checkDays.TabStop = true;
            this.checkDays.Text = "in Tagen";
            this.checkDays.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(116, 164);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(161, 20);
            this.result.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ausgabe Reisedauer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 192);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.RadioButton checkHours;
        private System.Windows.Forms.RadioButton checkDays;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcButton;
    }
}

