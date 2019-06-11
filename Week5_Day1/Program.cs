using System;
using System.Linq;

namespace Week5_Day1
{
    class Program
    {
        static Func<int, int> add(int x)
        {
            return y => x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(add(5)(2));

            Console.ReadLine();
        }

        static void notMain()
        {
            int[] myArr = new int[] { 1, 5, 10, 4, 2 };

            var a = from x in myArr
                    select Math.Pow(x, 2) into power
                    where power % 2 == 0
                    select power;

            var b = myArr
                .Select(x => Math.Pow(x, 2))
                .Where(x => x % 2 == 0);


            // Console.WriteLine(String.Join(' ', a));
            // Console.WriteLine(String.Join(' ', b));
        }
    }
}
