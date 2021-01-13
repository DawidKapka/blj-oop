using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A04
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
            ctrl.Unit = GetUnit();
            ctrl.Birth = datePicker.Value;
            try
            {
                result.Text = Convert.ToString(ctrl.GetTimeSpan(ctrl.Today, ctrl.Birth, ctrl.Unit));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
            


        }

        String GetUnit()
        {
            String unit = null;
            if (checkYears.Checked)
            {
                unit = "years";
            } 
            else if (checkMonths.Checked)
            {
                unit = "months";
            }
            else if (checkWeeks.Checked)
            {
                unit = "weeks";
            }
            else if (checkDays.Checked)
            {
                unit = "days";
            }
            return unit;
        }
    }
}
