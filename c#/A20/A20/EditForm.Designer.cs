namespace A20
{
    partial class EditForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.ComboBox();
            this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.crDateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.stateBox);
            this.groupBox1.Controls.Add(this.dueDatePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.crDateLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.descBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.titleBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(225, 264);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 28);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "State:";
            // 
            // stateBox
            // 
            this.stateBox.FormattingEnabled = true;
            this.stateBox.Location = new System.Drawing.Point(119, 235);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(194, 23);
            this.stateBox.TabIndex = 5;
            // 
            // dueDatePicker
            // 
            this.dueDatePicker.Location = new System.Drawing.Point(119, 206);
            this.dueDatePicker.Name = "dueDatePicker";
            this.dueDatePicker.Size = new System.Drawing.Size(194, 23);
            this.dueDatePicker.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Due Date:";
            // 
            // crDateLabel
            // 
            this.crDateLabel.AutoSize = true;
            this.crDateLabel.Location = new System.Drawing.Point(120, 182);
            this.crDateLabel.Name = "crDateLabel";
            this.crDateLabel.Size = new System.Drawing.Size(0, 15);
            this.crDateLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Creation Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(120, 51);
            this.descBox.Multiline = true;
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(193, 123);
            this.descBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(120, 22);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(193, 23);
            this.titleBox.TabIndex = 0;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 323);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditForm";
            this.Text = "Edit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox stateBox;
        private System.Windows.Forms.DateTimePicker dueDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label crDateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button saveButton;
    }
}