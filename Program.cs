using System;
using System.Collections.Generic;

namespace ParkAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Constant to set parkingspaces. Same for every new Garage*/
            const int space= 5;
            //For test purposes
            // //Console.WriteLine("Hello World!");
            // var air = new Airplane();
            //Console.WriteLine($"I am flying {air.airline}.");
            //var v = new Vehicle();
            //v.Driving();
            //var c = new Car();
            //c.Driver();
            //air.FlyingHigh();
            //v.info();
            //Garage garage = new Garage("Big Parking", "London", 5, 1500);
            //Console.WriteLine($"Name: {garage.Name} City: {garage.City} Levels: {garage.Levels} Capacity: {garage.Capacity}");

            Console.WriteLine();
            //var bussing = new Bus();
            //bussing.Commute();
            //var bigship = new Boat();
            //bigship.Sailing();


            //Garage garage2 = new Garage("Huge Parking", "Dallas", 7, 13000);
            //Console.WriteLine($"Name: {garage2.Name} City: {garage2.City} Levels: {garage2.Levels} Capacity: {garage2.Capacity}");
            ////garage.name = "Big Parking";
            ////garage.city = "London";
            ////garage.levels = 5;
            ////garage.capacity = 1500;
            ////garage.About();
            ////Dallas d = new Dallas("Big Parking", "Phoenix", 5, 1500);
            ////Console.WriteLine(d.City);

            //var sm = new Menu();
            //sm.Show_Menu();

            var g = new Garage<Vehicle>("Park n Go","any",5,space);

            //Console.WriteLine("Input city where you want to park");
            //g.City = Console.ReadLine();
            //g.About();
            //Console.ReadKey();
            var sm = new Menu();
            sm.Show_Menu();

            /*I want to instantiate class/object to use in a List*/
            //var VehiclesLists = new Vehicle();
            //List<var> VehicleLists = new List<var>();
            //VehicleLists.Add("numb)

            List<Vehicle> vList = new List<Vehicle>();
            vList.Add(new Vehicle("CIA123", "Red", 4, "Car"));
            vList.Add(new Vehicle("kGB342", "Yellow", 4, "Boat"));
            vList.Add(new Vehicle("TBI321", "Black", 4, "AirPlane"));
            vList.Add(new Vehicle("MRI623", "Red", 4, "Car"));
            vList.Add(new Vehicle("FBI123", "White", 4, "Bike"));
            Console.WriteLine("Showing All");
            //Showing carinfo
            foreach (var v in vList)
            {
                Console.WriteLine($"Your car {v}");
            }





        }
    }
}
