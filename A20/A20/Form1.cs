using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20
{
    public partial class Form1 : Form
    {
        public static TaskList tasks = new TaskList();
        public Form1()
        {
            InitializeComponent();
            foreach (Task task in tasks.Tasks)
            {
                int rowId = dataGridView.Rows.Add();
                DataGridViewRow row = dataGridView.Rows[rowId];
                row.Cells["Title"].Value = "a";
            }

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Form2 createForm = new Form2();
            createForm.Show();

        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            this.Update();
        }
    }
}
