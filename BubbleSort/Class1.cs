using System;

namespace BubbleSort
{
    public class Class1
    {
        /// <summary>
        /// Sorts in place.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] BubbleSort(int[] arr)
        {
            int tmp;
            for (var j = 1; j < arr.Length; j++)
            {
                for (var i = 0; i < arr.Length - j; i++)
                {
                    if (arr[i] < arr[i + 1]) // swap condition
                    {
                        tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                    }
                }
            }
            return arr;
        }
    }
}
