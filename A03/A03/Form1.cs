using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            Controller ctrl = new Controller();
            ctrl.Days = checkDays.Checked;
            try
            {
                ctrl.SetSpeed(Convert.ToDouble(speed.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            result.Text = Convert.ToString(ctrl.CalculateResult(ctrl.Distance, ctrl.Speed, ctrl.Days));

        }
    }
}
