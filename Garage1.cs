using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ParkAndGo
{
    internal class Garage<T>
    {
        private string name;
        private string city;
        private int levels;
        private int capacity;

        public Garage(string name, string city, int levels, int capacity)
        {
            this.name = name;
            this.city = city;
            this.levels = levels;
            this.capacity = capacity;
        }
    }
}