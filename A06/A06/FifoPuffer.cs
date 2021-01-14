using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A06
{
    class FifoPuffer
    {
        static int size;
        int[] puffer = new int[size];
        public FifoPuffer(int pufferSize)
        {
            if (pufferSize <= 0)
            {
                throw new Exception("Puffergrösse muss grösser als 0 sein!");
            }
            size = pufferSize;
            Array.Resize(ref puffer, size + 1);
        }
        public void Put(int value)
        {
            if (value <= 0)
            {
                throw new Exception("Der Wert muss grösser als 0 sein!");
            }
            bool isSet = false;
            for (int i = 0; i < puffer.Length-1; i++)
            {
                if (puffer[i] == 0)
                {
                    puffer[i] = value;
                    isSet = true;
                    break;
                }
            }
            if (!isSet)
            {
                throw new Exception("Puffer ist Voll!");
            }
        }
        public int Get()
        {
            if (puffer[0] == 0)
            {
                throw new Exception("Puffer ist leer!");
            }
            int result = puffer[0];
            puffer[0] = 0;
            UpdatePuffer();

            return result;
        }
        public String GetAll()
        {
            if (puffer[0] == 0)
            {
                throw new Exception("Puffer ist leer!");
            }
            String all = "";
            for (int i = 0; i < puffer.Length - 1; i++)
            {
                all += puffer[i] + ", ";
                puffer[i] = 0;
            }
            return all;
        }
        public void UpdatePuffer()
        {
            for (int i = 0; i < puffer.Length - 1; i++)
            {

                puffer[i] = puffer[i + 1];
            }
        }

    }
}
