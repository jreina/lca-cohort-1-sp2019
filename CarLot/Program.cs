using System;
using System.Collections.Generic;

namespace CarLot
{
    class CarLot
    {
        public string Name;
        public List<Vehicle> vehicles;
    }

    abstract class Vehicle
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
