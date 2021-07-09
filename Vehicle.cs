//using ParkAndGo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkAndGo
{
    public class Vehicle /*: IVehicle*/
    {
        private string numberplate { get; set; }
        private string color { get; set; }
        private int numofwheels { get; set; }
        private string type { get; set; }
        public void Driving()
        {
            Console.WriteLine("I am out driving.");
        }

        public void Info()
        {
            Console.WriteLine($"Your car {numberplate}{color}{numofwheels}{type}");
        }

        public void ShowAll()
        {
            Console.WriteLine("Showing All");
        }
    }
   
    
    class Airplane : Vehicle

    {
        private string seats { get; set; }

        
        public string airline;
        public void FlyingHigh()
        {
            Console.WriteLine("Iam Flying High.");
        }

       
        
    }

    class Car : Airplane
    {
        
        //public Car c = new Car();
        private string fuel { get; set; }
        
        public void Driver()
        {
            Console.WriteLine("WTF.");

        }
        public void Fuel()
        {

            Console.WriteLine();
        }
    }
    class Bike : Car
    {
        private string fueltype;
        public void Riding()
        {
            Console.WriteLine("Riding my bike");
        }
    }
    class Bus : Bike
    {

        private int Cylindervolume;
        public void Commute()
        {
            Console.WriteLine("I am commuting to work.");
        }
    }

    class Boat : Bus
    {
        public void Sailing()
        {
            Console.WriteLine("I am sailing");
        }
    }

}






