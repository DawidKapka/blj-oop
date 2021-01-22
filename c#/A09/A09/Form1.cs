using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A09
{
    public partial class Form1 : Form
    {
        List<C> instances = new List<C>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            instances.Add(new C());
            countBox.Text = Convert.ToString(instances.Count());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            instances.Clear();
            countBox.Text = Convert.ToString(instances.Count());
        }
    }
}
