using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ParkAndGo
{
    public class Garage<T>
    {
        private string Name { get; set; }
        private string City { get; set; }
        private int Levels { get; set; }
        private int Capacity { get; set; }

        public Garage(string name, string city, int levels, int capacity)
        {
            this.Name = name;
            this.City = city;
            this.Levels = levels;
            this.Capacity = capacity;
        }

        public void GarageInfo()
        {
            Console.WriteLine($"Info about your garage.");
            Console.WriteLine($"Name: {Name}, City {City}, Levels: {Levels} and Capacity: {Capacity}");
        }
    }
}