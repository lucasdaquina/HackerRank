using System;
using System.Collections.Generic;
using System.Linq;

namespace TheBirthdayBar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = Birthday(s, d, m);

            Console.WriteLine(result);
        }

        static int Birthday(List<int> s, int d, int m)
        {
            var listToSum = new List<List<int>>();

            while (s.Count != m - 1)
            {
                var enter = new List<int>();
                for (int j = 0; j < m; j++)
                {
                    enter.Add(s[j]);
                }
                var aux = s[0];
                s.Remove(aux);
                listToSum.Add(enter);
            }

            return listToSum.Where(_ => _.Sum(x => x) == d).Count();
        }
    }
}
