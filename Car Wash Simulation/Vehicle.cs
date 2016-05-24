using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Wash_Simulation
{
    public class Vehicle
    {
        public string size;
        public string CarName;
        public bool indoor;
        public int seats;
        public Vehicle(string _size, string name, bool _indoor, int _seats)
        {
            CarName = name;
            size = _size;
            indoor = _indoor;
            seats = _seats;
        }
        
    }
}
