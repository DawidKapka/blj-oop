using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A04
{
    class Controller
    {
        String unit;
        DateTime today = DateTime.Today;
        DateTime birth;

        public String Unit
        {
            set { unit = value; }
            get { return unit; }
        }
        public DateTime Birth
        {
            set { birth = value; }
            get { return birth; }
        }
        public DateTime Today
        {
            get { return today; }
        }

        public int GetTimeSpan(DateTime today, DateTime birth, String unit)
        {
            int result = 0;

            if (unit == null)
            {
                throw new Exception("Keine Einheit ausgewählt!");
            }
            TimeSpan interval = today - birth;
            if (unit == "years")
            {
                result = interval.Days / 365;
            }
            else if (unit == "months")
            {
                result = interval.Days / 30;
            }
            else if (unit == "weeks")
            {
                result = interval.Days / 7;
            }
            else if (unit == "days")
            {
                result = interval.Days;
            }
            
            return result;

        }
    }
}
