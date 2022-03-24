using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.maximum_Acceleration = "100 kmh";
            car.seat.seatwarmer = true;
            car.seat.comfortability = "Comfy";
            car.wheel.curcumference = "2m";
            car.engine.maximumFuelConsumptionRate = "100";
            car.door.opoeningMode = "Upward Ways";


            Console.WriteLine("Car Information    " + car.DisplayCarInfo());
            Console.ReadKey();
        }
    }
}
