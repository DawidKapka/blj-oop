using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FifoPuffer puffer;

        private void createButton_Click(object sender, EventArgs e)
        {
            if (sizeBox.Text != "")
            {
                try
                {
                    puffer = new FifoPuffer(Convert.ToInt32(sizeBox.Text));
                    label4.Text = "Puffer wurde erstellt.";
                    putButton.Enabled = true;
                    getButton.Enabled = true;
                    getAllButton.Enabled = true;
                    putBox.Enabled = true;
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(800);
                    label4.Text = "";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Bitte geben sie die Grösse an!");
            }
            
            
        }

        private void putButton_Click(object sender, EventArgs e)
        {
            try
            {
                puffer.Put(Convert.ToInt32(putBox.Text));
                label5.Text = "Wert wurde hinzugefügt.";
                Application.DoEvents();
                System.Threading.Thread.Sleep(800);
                label5.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void getAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultBox.Text = puffer.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultBox.Text = Convert.ToString(puffer.Get());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sizeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void putBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
