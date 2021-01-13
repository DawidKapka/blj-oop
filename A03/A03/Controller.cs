using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A03
{
    class Controller
    {
        bool days = false;
        double distance = 384400;
        double speed;

        public bool Days
        {
            set { days = value; }
            get { return days; }
        }
        public double Distance
        {
            get { return distance; }
        }
        public double Speed
        {
            get { return speed; }
        }

        public void SetSpeed(double speedValue)
        {
            if (speedValue <= 0)
            {
                throw new Exception("Geschwindigkeit muss höher als 0km/h sein.");
            }
            speed = speedValue;
        }

        public double CalculateResult(double distance, double speed, bool days)
        {
            double result = distance / speed;
            if (days)
            {
                result = result / 24;
            }
            return result;
        }
    }
}
