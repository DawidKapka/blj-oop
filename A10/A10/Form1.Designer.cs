namespace A10
{
    partial class Form1
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
            this.addButton = new System.Windows.Forms.Button();
            this.addBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ascButton = new System.Windows.Forms.RadioButton();
            this.descButton = new System.Windows.Forms.RadioButton();
            this.getButton = new System.Windows.Forms.Button();
            this.getBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(214, 29);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 29);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addBox
            // 
            this.addBox.Location = new System.Drawing.Point(97, 33);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(111, 23);
            this.addBox.TabIndex = 1;
            this.addBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zahl:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sortierreihenfolge:";
            // 
            // ascButton
            // 
            this.ascButton.AutoSize = true;
            this.ascButton.Location = new System.Drawing.Point(64, 41);
            this.ascButton.Name = "ascButton";
            this.ascButton.Size = new System.Drawing.Size(81, 19);
            this.ascButton.TabIndex = 4;
            this.ascButton.TabStop = true;
            this.ascButton.Text = "Ascending";
            this.ascButton.UseVisualStyleBackColor = true;
            // 
            // descButton
            // 
            this.descButton.AutoSize = true;
            this.descButton.Location = new System.Drawing.Point(64, 66);
            this.descButton.Name = "descButton";
            this.descButton.Size = new System.Drawing.Size(87, 19);
            this.descButton.TabIndex = 5;
            this.descButton.TabStop = true;
            this.descButton.Text = "Descending";
            this.descButton.UseVisualStyleBackColor = true;
            // 
            // getButton
            // 
            this.getButton.Enabled = false;
            this.getButton.Location = new System.Drawing.Point(214, 188);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(85, 29);
            this.getButton.TabIndex = 0;
            this.getButton.Text = "Get";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // getBox
            // 
            this.getBox.Enabled = false;
            this.getBox.Location = new System.Drawing.Point(58, 237);
            this.getBox.Name = "getBox";
            this.getBox.Size = new System.Drawing.Size(241, 23);
            this.getBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.descButton);
            this.groupBox2.Controls.Add(this.ascButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 150);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.clearButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 68);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clear";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Zahlenspeicher leeren:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(202, 22);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(85, 29);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 382);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.getBox);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ascButton;
        private System.Windows.Forms.RadioButton descButton;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.TextBox getBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearButton;
    }
}

