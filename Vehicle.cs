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
        private string Licenseplate { get; set; }
        private string Color { get; set; }
        private int Numofwheels { get; set; }
        private string Vtype { get; set; }

        public Vehicle(string licenseplate, string color, int numofwheels, string type)
        {
            this.Licenseplate = licenseplate;
            this.Color = color;
            this.Numofwheels = numofwheels;
            this.Vtype = type;
        }
        //List<Vehicle> vList = new List<Vehicle>();

        public Vehicle()
        {

        }

        


        //VehicleList.add(New)
            
        public void Driving()
        {
            Console.WriteLine("I am out driving.");
        }

        /*--Properties--
            licenseplate,color,numofwheels,type
        */

        
        public void Info()
        {
            //foreach(var inf in Vehicle)
            //{
              Console.WriteLine($"Your car {Licenseplate}{Color}{Numofwheels}{Vtype}");
            //}
            
            

        }

        public void ShowAll()
        {
            Console.WriteLine("Showing something later on.");
            
        }
    }
   
    
    public class Airplane : Vehicle

    {
        private string seats { get; set; }

        private string airline { get; set; }
        public void FlyingHigh()
        {
            Console.WriteLine("Iam Flying High.");
        }
        //public Airplane(string licenseplate, string color, int numofwheels, string type)
        //{

        //}
       
        
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






