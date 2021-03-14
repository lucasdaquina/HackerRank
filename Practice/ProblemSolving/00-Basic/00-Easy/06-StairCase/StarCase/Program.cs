using System;

namespace StairCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Staircase(n);
        }

        static void Staircase(int n)
        {

            int i = 1;
            while (i <= n)
            {
                var a = new String(' ', n - i);
                var resh = new String('#', i);
                Console.WriteLine(a + resh);
                i++;
            }

        }
    }
}
