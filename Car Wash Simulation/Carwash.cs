using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Wash_Simulation
{
    public class Carwash
    {
        public int WashTime=0;
        public int DryTime=0;
        public int IndoorTime = 0;

        public int ResetWash()
        { 
            WashTime = 0;
            return WashTime;
            
        }
        public int ResetDry()
        {
            DryTime = 0;
            return DryTime;
        }

        public int ResetIndoor()
        {
            IndoorTime = 0;
            return IndoorTime;
        }
        //sets time to wash the selected car
        public int WashTimeSet(Vehicle car)
        {
            if (car.size == "Wagon")
            {
                WashTime = WashTime + 3;
                DryTime = DryTime + 2;
            }
            else if (car.size == "Sedan")
            {
                WashTime = WashTime + 2;
                DryTime = DryTime + 2;
            }
            else if (car.size == "Truck")
            {
                WashTime = WashTime + 4;
                DryTime = DryTime + 5;

            }
            else if (car.size == "Van")
            {
                WashTime = WashTime + 5;
                DryTime = DryTime + 5;
            }
            return WashTime;
        }

        public int IndoorTimeSet(Vehicle car)
        {
            if (car.indoor == true)
            {
                IndoorTime = car.seats;
            }
            else
            { IndoorTime = 0; }
            return IndoorTime;
        }


        // Sets the time to dry the selected car;
        /*public int DryTimeSet(Vehicle car)
        {
            if (car.size == "Wagon")
            { DryTime = DryTime + 3; }
            else if (car.size == "Sedan")
            { DryTime = DryTime + 4; }
            else if (car.size == "Truck")
            { DryTime = DryTime + 5; }
            return DryTime;
        }*/


        public void job(Vehicle jCar, out int pWashTime, out int pDryTime, out int pIndoorTime)
        {
            ResetWash();
            ResetDry();
            ResetIndoor();
            WashTimeSet(jCar);
            IndoorTimeSet(jCar);
            pWashTime = WashTime;
            pDryTime = DryTime;
            pIndoorTime = IndoorTime;

        }
      
    }
}
