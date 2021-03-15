using System;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));
            CountApplesAndOranges(s, t, a, b, apples, oranges);
        }


        static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            var countApples = 0;
            var countOranges = 0;

            foreach (var ap in apples)
            {
                var r = a + ap;
                if (r >= s && r <= t)
                {
                    countApples++;
                }
            }

            foreach (var or in oranges)
            {
                var r = b + or;
                if (r >= s && r <= t)
                {
                    countOranges++;
                }
            }

            Console.WriteLine(countApples);
            Console.WriteLine(countOranges);
        }
    }
}
