using System;
using System.Linq;

namespace VeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            long result = AVeryBigSum(ar);
        }


        static long AVeryBigSum(long[] ar)
        {
            return ar.Sum();
        }
    }
}
