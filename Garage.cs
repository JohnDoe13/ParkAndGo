using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkAndGo
{
    public class Garage<T> : IEnumerable<Vehicle> /*IEnumerable<T> where T : IVehicle*/
    {
        
        
        public string Name="Park n Go";
        public int Levels=5;
        public string City;
        public int Capacity=5;

        private Vehicle[] vehicles;
        //int[] space = new int[1500];


        public void About()
        {
            Console.WriteLine("Input city where you want to park");
            City = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"---Garage info---\nName: {Name} {City}\nLevels: {Levels}\nCity: {City}\nCapacity: {Capacity}.");
            Console.WriteLine("Press Enter to proceed to menu.");
            Console.ReadKey();
           
            //Console.ReadKey();
        }

        public Garage(string name, string city, int levels, int capacity)
        {
            this.Name = name;
            this.City = city;
            this.Levels = levels;
            this.Capacity = capacity;
            //instansera vehicles-arrayen
        }

        void Park(Vehicle vehicle)
        {
            // iterera över fältet vehicles
            // kolla varje plats om det är == null
            // om 'ja': vehicles[i] = vehicle
            // break loop
        }

        void Unpark(string regNr)
        {
            // iterera över fältet vehicles
            // kolla varje plats om den inte är null samt har vehicle[i].RegNr == regNr
            // om 'ja': vehicle[i] == null
            // break loop
        }


        void TaBort()
        {
            var garage = new Garage<IVehicle>("""");
            foreach (var vehicle in garage)
            {
                Console.WriteLine($"{vehicle}");
            }
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle != null)
                {
                    yield return vehicle;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    //class Dallas : Garage
    //{
    //    public Dallas(string name, string city, int levels, int capacity): base( name,  city, levels, capacity)
    //    {
            
    //    }
    //}

    //Create parkingspace and set it to a fix size according to location. See above.

    


}
