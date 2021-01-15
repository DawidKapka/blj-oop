using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A08
{
    class Car
    {
        String brand;
        int ps;
        int speed;
        int gear = 1;
        bool engineStarted;
        

        public String Brand
        {
            get { return brand; }
        }
        public bool EngineStarted
        {
            set { engineStarted = value; }
            get { return engineStarted; }
        }
        public int Speed
        {
            get { return speed; }
        }
        public int Ps
        {
            get { return ps; }
        }
        public int Gear
        {
            get { return gear; }
        }

        public Car(String brandValue, int psValue)
        {
            brand = brandValue;
            ps = psValue;
        }

        public void Accelerate()
        {
            int maxSpeed = ps + 100;
            if (speed < maxSpeed)
            {
                speed += ps / 45;
                System.Threading.Thread.Sleep(200);
            }
            else if (maxSpeed - speed < ps / 15)
            {
                speed = maxSpeed;
            }
            changeGear();

            

            

        }
        public void Break()
        {
            if (speed > 0 && speed > ps / 20)
            {
                speed -= ps / 20;
                System.Threading.Thread.Sleep(200);
            }
            else if (speed > 0)
            {
                speed = 0;
            }
            changeGear();
        }
        void changeGear()
        {
            if (speed < 10)
            {
                gear = 1;
            }
            if (speed > 10)
            {
                gear = 2;
            }
            if (speed > 20)
            {
                gear = 3;
            }
            if (speed > 40)
            {
                gear = 4;
            }
            if (speed > 70)
            {
                gear = 5;
            }
            if (speed > 100)
            {
                gear = 6;
            }
        }
    }

}
