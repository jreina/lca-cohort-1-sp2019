using System;
using System.Linq;
using System.Collections.Generic;

namespace Inventory
{
    //Create an interface that is called IRentable.
    //Your interface should have 2 methods:
    //GetDailyRate()
    //GetDescription()
    //Create 3 classes that extend IRentable interface

    //Boat
    //House
    //Car
    //The Car class should internally store a daily rate.
    //The Boat class should internally store an hourly rate
    //The House class should internally store a weekly rate.
    //In your Main Method, you should instantiate some Cars, Houses, and Boats, and add them to a single list.
    //Then loop through the list and print the description, type and daily rate out to the console for each element in the list.

    interface IRentable
    {
        decimal GetDailyRate();
        string GetDescription();
    }

    class Boat : IRentable
    {
        private decimal _hourlyRate;

        public Boat(decimal hourlyRate)
        {
            _hourlyRate = hourlyRate;
        }

        public decimal GetDailyRate()
        {
            return _hourlyRate * 24;
        }

        public string GetDescription()
        {
            return "I am a butt";
        }
    }

    class House : IRentable
    {
        private decimal _weeklyRate;

        public House(decimal weeklyRate)
        {
            _weeklyRate = weeklyRate;
        }

        public decimal GetDailyRate()
        {
            return _weeklyRate / 7;
        }

        public string GetDescription()
        {
            return "I am a house";
        }
    }

    class Car : IRentable
    {
        private decimal _dailyRate;

        public Car(decimal dailyRate)
        {
            _dailyRate = dailyRate;
        }

        public decimal GetDailyRate()
        {
            return _dailyRate;
        }

        public string GetDescription()
        {
            return "I am a car";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<IRentable>()
            {
                new Boat(56),
                new House(875),
                new Car(39)
            };
            list.ForEach(item => Console.WriteLine($"{item.GetDescription()} - daily rate: {item.GetDailyRate()}"));

            Console.ReadLine();
        }
    }
}
