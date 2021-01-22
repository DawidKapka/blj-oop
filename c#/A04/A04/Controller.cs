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

        public int GetTimeSpan()
        {
            int result = 0;

            if (unit == null)
            {
                throw new Exception("Keine Einheit ausgewählt!");
            }
            TimeSpan span = today - birth;
            if (unit == "years")
            {
                result = Convert.ToInt32(Math.Floor(span.TotalDays / 365));
            }
            else if (unit == "months")
            {
                result = Convert.ToInt32(Math.Floor(span.TotalDays / 30.4));
            }
            else if (unit == "weeks")
            {
                result = Convert.ToInt32(Math.Floor(span.TotalDays / 7));
            }
            else if (unit == "days")
            {
                result = Convert.ToInt32(span.TotalDays);
            }
            return result;

        }
    }
}
