namespace A08
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxCars = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accButton = new System.Windows.Forms.Button();
            this.breakButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.engineLight = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gearBox = new System.Windows.Forms.TextBox();
            this.kmhBox = new System.Windows.Forms.TextBox();
            this.psLabel = new System.Windows.Forms.Label();
            this.accTimer = new System.Windows.Forms.Timer(this.components);
            this.breakTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCars
            // 
            this.comboBoxCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxCars.FormattingEnabled = true;
            this.comboBoxCars.Location = new System.Drawing.Point(521, 26);
            this.comboBoxCars.Name = "comboBoxCars";
            this.comboBoxCars.Size = new System.Drawing.Size(181, 28);
            this.comboBoxCars.TabIndex = 0;
            this.comboBoxCars.SelectedIndexChanged += new System.EventHandler(this.comboBoxCars_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Auto Wählen:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.accButton);
            this.groupBox1.Controls.Add(this.breakButton);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.engineLight);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 368);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Simulator";
            // 
            // accButton
            // 
            this.accButton.Enabled = false;
            this.accButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accButton.Location = new System.Drawing.Point(654, 169);
            this.accButton.Name = "accButton";
            this.accButton.Size = new System.Drawing.Size(94, 174);
            this.accButton.TabIndex = 5;
            this.accButton.Text = "Gas";
            this.accButton.UseVisualStyleBackColor = true;
            this.accButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.accButton_MouseDown);
            this.accButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.accButton_MouseUp);
            // 
            // breakButton
            // 
            this.breakButton.Enabled = false;
            this.breakButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakButton.Location = new System.Drawing.Point(454, 169);
            this.breakButton.Name = "breakButton";
            this.breakButton.Size = new System.Drawing.Size(180, 174);
            this.breakButton.TabIndex = 4;
            this.breakButton.Text = "Bremse";
            this.breakButton.UseVisualStyleBackColor = true;
            this.breakButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.breakButton_MouseDown);
            this.breakButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.breakButton_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // engineLight
            // 
            this.engineLight.BackColor = System.Drawing.Color.Silver;
            this.engineLight.ForeColor = System.Drawing.Color.Black;
            this.engineLight.Location = new System.Drawing.Point(117, 32);
            this.engineLight.Name = "engineLight";
            this.engineLight.Size = new System.Drawing.Size(16, 17);
            this.engineLight.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.startButton.Enabled = false;
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.Location = new System.Drawing.Point(35, 32);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 53);
            this.startButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startButton.TabIndex = 1;
            this.startButton.TabStop = false;
            this.startButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.gearBox);
            this.panel1.Controls.Add(this.kmhBox);
            this.panel1.Location = new System.Drawing.Point(234, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 128);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(384, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gear";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "km/h";
            // 
            // gearBox
            // 
            this.gearBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.gearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 41.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gearBox.ForeColor = System.Drawing.Color.Aqua;
            this.gearBox.Location = new System.Drawing.Point(387, 43);
            this.gearBox.Name = "gearBox";
            this.gearBox.Size = new System.Drawing.Size(127, 70);
            this.gearBox.TabIndex = 1;
            this.gearBox.Text = "1";
            this.gearBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kmhBox
            // 
            this.kmhBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.kmhBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 41.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmhBox.ForeColor = System.Drawing.Color.Lime;
            this.kmhBox.Location = new System.Drawing.Point(21, 43);
            this.kmhBox.Name = "kmhBox";
            this.kmhBox.Size = new System.Drawing.Size(328, 70);
            this.kmhBox.TabIndex = 0;
            this.kmhBox.Text = "0";
            this.kmhBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // psLabel
            // 
            this.psLabel.AutoSize = true;
            this.psLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.psLabel.Location = new System.Drawing.Point(713, 29);
            this.psLabel.Name = "psLabel";
            this.psLabel.Size = new System.Drawing.Size(47, 20);
            this.psLabel.TabIndex = 3;
            this.psLabel.Text = "0 PS";
            // 
            // accTimer
            // 
            this.accTimer.Tick += new System.EventHandler(this.accTimer_Tick);
            // 
            // breakTimer
            // 
            this.breakTimer.Tick += new System.EventHandler(this.breakTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.psLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCars);
            this.Name = "Form1";
            this.Text = "Auto Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox startButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gearBox;
        private System.Windows.Forms.TextBox kmhBox;
        private System.Windows.Forms.Button accButton;
        private System.Windows.Forms.Button breakButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel engineLight;
        private System.Windows.Forms.Label psLabel;
        private System.Windows.Forms.Timer accTimer;
        private System.Windows.Forms.Timer breakTimer;
    }
}

