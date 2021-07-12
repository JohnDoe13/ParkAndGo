using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkAndGo
{
    class Menu
    {
        //Show all Vehicles
        //Show type and how many of each type
        //Add and remove Vehicles
        //Capacity i.e. parking spots (how many?)
        //Search for vehicles and/or with types.
        //Confirmation i.e. parking accepted or not. If not, why?
        //Exit through menu
        /* Remember proper error handling. We conly want valid data.*/
        public void Show_Menu()
        {
            int selection;
            var gg = new Garage("Park n Go", "any", 5, 5);
            gg.About();

            do
            {
                //bool proceed = true;
                Console.Clear();
                Console.WriteLine("***Welcome to ParkAndGo.***\n\nPlease follow the instructions on the screen.\nTo exit, enter 0 <zero> at anytime.");

                Console.WriteLine();

                Console.WriteLine("Note: always press Enter to return to menu");

                Console.WriteLine();

                Console.WriteLine("1) Show all vehicles.");
                Console.WriteLine("2) Show type and how many of each type.");
                Console.WriteLine("3) Add and remove vehicles.");
                Console.WriteLine("4) Capacity i.e free parkingspots.");
                Console.WriteLine("5) Search for vehicles and/or with types.");
                Console.WriteLine("6) Confirmation i.e. parking accepted or not?");
                Console.WriteLine("0) Exit");
                Console.WriteLine("------------------------------");
                Console.Write("Make your selection:");
                selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        ShowAll();
                        Console.ReadLine();
                        break;

                    case 2:
                        ShowingType();
                        Console.ReadLine();
                        break;
                    case 3:
                        AddRemove();
                        Console.ReadLine();
                        break;
                    case 4:
                        ShowingCapacity();
                        Console.ReadLine();
                        break;

                    case 5:
                        SearchVehicles();
                        Console.ReadLine();
                        break;
                    case 6:
                        Confirmation();
                        Console.ReadLine();
                        break;
                    case 0:
                        Console.WriteLine("Are you sure you want to exit? Press 'Y' or 'y'");
                        if (Console.ReadKey().Key != ConsoleKey.Y)
                        {
                            Show_Menu();
                        }
                        else
                        {
                            Environment.Exit(1);

                        }
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Wrong input. Please, try again.");
                        break;

                }


            } while (selection != 0);
        }


        public void ShowAll()
        {
            Console.WriteLine("Showing All");
        }

        public void ShowingType()
        {
            Console.WriteLine("Showing type and how many");
        }

        public void AddRemove()
        {
            Console.WriteLine("Here we can Add and Remove vehicles");
        }
        public void ShowingCapacity()
        {
            Console.WriteLine("What's the capacity?");
        }
        public void SearchVehicles()
        {
            Console.WriteLine("Search for a vehicle.");
        }
        public void Confirmation()
        {
            Console.WriteLine("Confirm your parking.");
        }
        //public void MoreInfo()
        //{
        //    List<Vehicle> vList = new List<Vehicle>();
        //    vList.Add(new Vehicle("CIA123", "Red", 4, "Car"));
        //    vList.Add(new Vehicle("kGB342", "Red", 4, "Boat"));
        //    vList.Add(new Vehicle("TBI321", "Red", 4, "AirPlane"));
        //    vList.Add(new Vehicle("MRI623", "Red", 4, "Car"));
        //    vList.Add(new Vehicle("FBI123", "Red", 4, "Bike"));
        //    Console.WriteLine("Showing All");
        //    //Showing carinfo
        //    foreach (var v in vList)
        //    {
        //        Console.WriteLine($"Your car {v}");
        //    }
    }
}

