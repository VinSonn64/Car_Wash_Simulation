using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Wash_Simulation
{
    class CarWashManager
    {
        public int CarPosition=0;
        //List of Cars
        public List<Vehicle> CarList = new List<Vehicle>
       {
           new Vehicle("Wagon", "Suzuki Wagon", true, 4),
           new Vehicle("Van", "Mystery Machine", false, 6),
           new Vehicle("Sedan","Hyundai Genesis", true, 4),
           new Vehicle("Truck","Ford Atlas", false, 2),
          
           new Vehicle("Game","Over", false, 0)
       };

        
        
    public bool islastcar()
    { 
    return (CarPosition == CarList.Count()-1);
    }

        public Vehicle CurCar()
        {
            //car position = curcar, starting at 0
            //advances to the next car by 1 until the current car position equals the amount of car in CL through CL.Count
            Vehicle curVehicle = CarList[CarPosition];
            
            return curVehicle;
        }
        public int NextCar()
        {
            if (CarPosition < CarList.Count())
                CarPosition++;
            return CarPosition;
        }
        

    }
}
