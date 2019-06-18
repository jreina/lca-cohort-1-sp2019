using System;

namespace MoveZeroes
{
    class Util
    {
        public static void MoveZeroes(int[] arr)
        {
            for(var i = 0; i < arr.Length; i++)
            {
                for(var j = 0; j < arr.Length - i - 1; j++)
                {
                    if(arr[j] == 0)
                    {
                        arr[j] = arr[j + 1];
                        arr[j + 1] = 0;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 2, 0, 5, 0, 10, 11 };

            Util.MoveZeroes(arr);
            Console.WriteLine(String.Join(", ", arr));
            Console.ReadLine();
        }
    }
}
