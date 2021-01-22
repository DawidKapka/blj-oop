using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02
{
    public class Controller
    {
        double width;
        double height;

        public double Width
        {
            get { return width; }
        }

        public double Height
        {
            get { return height; }
        }

        public void SetWidth(double widthValue)
        {
            if (widthValue <= 0)
            {
                throw new Exception("Breite muss grösser als 0 sein!");
            }
            width = widthValue;
        }
        public void SetLength(double heightValue)
        {
            if (heightValue <= 0)
            {
                throw new Exception("Länge muss grösser als 0 sein!");
            }
            height = heightValue;
        }
        public double CalculateResult()
        {
            double result = width * height;
            return result;
        }

    }
}
