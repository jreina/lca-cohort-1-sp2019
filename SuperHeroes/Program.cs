using System;
using System.Collections.Generic;

namespace SuperHeroes
{
    public class Person
    {
        internal string _name { get; set; }
        private string _nickname { get; set; }

        public Person(string name, string nickname)
        {
            _name = name;
            _nickname = nickname;
        }

        public override string ToString()
        {
            return _name;
        }

        public virtual string PrintGreeting()
        {
            return $"Hi, my name is {_name}, you can call me {_nickname}.";
        }
    }
    public class SuperHero : Person
    {
        private string _realname { get; set; }
        private string _superpower { get; set; }

        public SuperHero(string name, string realname, string superpower) : base(name, null)
        {
            _realname = realname;
            _superpower = superpower;
        }
        public override string PrintGreeting()
        {
            return $"I am {_realname}. When I am {_name}, my super power is {_superpower}!";
        }
    }
    public class Villain : Person
    {

        public string _nemesis { get; set; }

        public Villain(string name, string nemesis) : base(name, null)
        {
            _nemesis = nemesis;
        }
        public override string PrintGreeting()
        {
            return $"I am {_name}! Have you seen {_nemesis}?";
        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            var peeps = new List<Person>()
            {
                new Person("William", "Bill"),
                new SuperHero("Mr. Incredible", "super strength", "Wade Turner"),
                new Villain("The Joker", "Batman")
            };

            peeps.ForEach(peep => Console.WriteLine($"{peep.ToString()}: {peep.PrintGreeting()}"));
            Console.Read();
        }
    }
}
