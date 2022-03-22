using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTaxi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //membuat object taxi
            Taxi taxi = new Taxi();

            //pengesetan nilai properties
            taxi.DriverName = "Aldebaran";
            taxi.OnDuty = true;
            taxi.NumPassenger = 8;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
