using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9task_01
{
    internal class Car
    {
       public Seat seat=new Seat();
       public Door door=new Door();
       public Wheel wheel=new Wheel();
        public Engine engine=new Engine();  

        public string maximum_Acceleration;
        public string fuel_Capacity;
        public string DisplayCarInfo()
        {
            return ("Acceleration:" + maximum_Acceleration + "\t" + "Fuel Capacity:" + fuel_Capacity + "\t" + "Comfortability : " + seat.comfortability + "\t" + "Seat Warmer:" + seat.seatwarmer.ToString() + "\t" + "Wheel Circumference:" + wheel.curcumference + "\t" + "Maximum Fuel Consumption rate:" + engine.maximumFuelConsumptionRate + "\t" + "Door Opening Mode:" + door.opoeningMode);

        }

    }
}
