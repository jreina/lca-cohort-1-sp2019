using System;
using System.Collections.Generic;

namespace TowerOfHanoi
{
    class TowerOfHanoi
    {
        private Dictionary<string, Stack<int>> _s = new Dictionary<string, Stack<int>>
        {
            { "A", new Stack<int>() },
            { "B", new Stack<int>() },
            { "C", new Stack<int>() }
        };
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
