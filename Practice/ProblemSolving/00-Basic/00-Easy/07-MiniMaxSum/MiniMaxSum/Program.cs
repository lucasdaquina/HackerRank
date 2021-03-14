using System;
using System.Linq;

namespace MiniMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            MiniMaxSum(arr);
        }

        static void MiniMaxSum(int[] arr)
        {
            var longs = arr.Select(item => (long)item).ToArray();
            var sortedArray = longs.ToList().OrderBy(_ => _);
            var max = sortedArray.Skip(1).Take(4).Sum();
            var min = sortedArray.Take(4).Sum();

            Console.WriteLine(min.ToString() + " " + max.ToString());
        }
    }
}
