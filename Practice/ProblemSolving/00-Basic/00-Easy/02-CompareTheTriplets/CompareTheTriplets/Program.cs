using System;
using System.Collections.Generic;
using System.Linq;

namespace CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = CompareTriplets(a, b);

        }

        static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            var result = new List<int>();
            var aWin = 0;
            var bWin = 0;
            int i = 0;
            while (i < a.Count)
            {
                if (a[i] > b[i])
                    aWin++;
                if (a[i] < b[i])
                    bWin++;
                i++;
            }
            result.Add(aWin);
            result.Add(bWin);

            return result;
        }
    }
}
