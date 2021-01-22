namespace A04
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkDays = new System.Windows.Forms.RadioButton();
            this.checkWeeks = new System.Windows.Forms.RadioButton();
            this.checkMonths = new System.Windows.Forms.RadioButton();
            this.checkYears = new System.Windows.Forms.RadioButton();
            this.calcButton = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.result);
            this.groupBox3.Location = new System.Drawing.Point(12, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 73);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ausgabe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calcButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eingabe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geburtsdatum";
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.datePicker.Location = new System.Drawing.Point(29, 54);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkDays);
            this.groupBox2.Controls.Add(this.checkWeeks);
            this.groupBox2.Controls.Add(this.checkMonths);
            this.groupBox2.Controls.Add(this.checkYears);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 60);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Einheit";
            // 
            // checkDays
            // 
            this.checkDays.AutoSize = true;
            this.checkDays.Location = new System.Drawing.Point(292, 29);
            this.checkDays.Name = "checkDays";
            this.checkDays.Size = new System.Drawing.Size(50, 17);
            this.checkDays.TabIndex = 3;
            this.checkDays.TabStop = true;
            this.checkDays.Text = "Tage";
            this.checkDays.UseVisualStyleBackColor = true;
            // 
            // checkWeeks
            // 
            this.checkWeeks.AutoSize = true;
            this.checkWeeks.Location = new System.Drawing.Point(194, 29);
            this.checkWeeks.Name = "checkWeeks";
            this.checkWeeks.Size = new System.Drawing.Size(66, 17);
            this.checkWeeks.TabIndex = 2;
            this.checkWeeks.TabStop = true;
            this.checkWeeks.Text = "Wochen";
            this.checkWeeks.UseVisualStyleBackColor = true;
            // 
            // checkMonths
            // 
            this.checkMonths.AutoSize = true;
            this.checkMonths.Location = new System.Drawing.Point(107, 29);
            this.checkMonths.Name = "checkMonths";
            this.checkMonths.Size = new System.Drawing.Size(61, 17);
            this.checkMonths.TabIndex = 1;
            this.checkMonths.TabStop = true;
            this.checkMonths.Text = "Monate";
            this.checkMonths.UseVisualStyleBackColor = true;
            // 
            // checkYears
            // 
            this.checkYears.AutoSize = true;
            this.checkYears.Location = new System.Drawing.Point(29, 29);
            this.checkYears.Name = "checkYears";
            this.checkYears.Size = new System.Drawing.Size(51, 17);
            this.checkYears.TabIndex = 0;
            this.checkYears.TabStop = true;
            this.checkYears.Text = "Jahre";
            this.checkYears.UseVisualStyleBackColor = true;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(253, 51);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(97, 23);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "Berechnen";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(84, 33);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(258, 20);
            this.result.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 265);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton checkDays;
        private System.Windows.Forms.RadioButton checkWeeks;
        private System.Windows.Forms.RadioButton checkMonths;
        private System.Windows.Forms.RadioButton checkYears;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
    }
}

