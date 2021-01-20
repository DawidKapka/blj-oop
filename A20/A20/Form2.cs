using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace A20
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }


        private void createButton_Click(object sender, EventArgs e)
        {
            Task newTask = new Task(titleBox.Text, descBox.Text, dateBox.Value, DateTime.Now, Task.State.Todo);
            Form1.tasks.Add(newTask);
            Update();
            this.Close();
        }
    }
}
