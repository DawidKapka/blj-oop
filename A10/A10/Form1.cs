using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A10
{
    public partial class Form1 : Form
    {
        NumberSaver saver = new NumberSaver();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (addBox.Text == null)
                {
                    throw new Exception("Es Wurde keine Zahl eingegeben!");
                }
                if (!saver.Contains(Convert.ToInt32(addBox.Text)))
                {
                    saver.Add(Convert.ToInt32(addBox.Text));
                    getButton.Enabled = true;
                    addBox.Clear();
                    addBox.Focus();
                }
                else
                {
                    throw new Exception("Diese Zahl wurde schon eingegeben!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void getButton_Click(object sender, EventArgs e)
        {
            if (ascButton.Checked)
            {
                getBox.Text = saver.Get(SortOrder.Ascending);
            }
            else
            {
                getBox.Text = saver.Get(SortOrder.Descending);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            saver.Clear();
            getButton.Enabled = false;
            getBox.Clear();
        }

        private void addBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
