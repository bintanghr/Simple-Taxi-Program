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
            Console.Write("Inputkan Nama Driver : ");
            taxi.DriverName = Console.ReadLine();
            Console.Write("On Duty [Yes or No] : ");
            taxi.OnDuty = Console.ReadLine().ToLower() == "yes" ? true : false;

            if (taxi.OnDuty)
            {
                Console.Write("Inputkan jumlah penumpang : ");
                taxi.NumPassenger = int.Parse(Console.ReadLine());

                //pemanggilan method
                Console.WriteLine("");
                taxi.TaxiInfo();
                taxi.PickUpPassenger();
                taxi.DropOffPassenger();
            }
            else
            {
                Console.WriteLine("");
                taxi.TaxiInfo();
            }

            Console.ReadKey();
        }
    }
}
