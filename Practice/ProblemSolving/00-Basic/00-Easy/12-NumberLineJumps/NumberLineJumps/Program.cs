using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberLineJumps
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            string result = Kangaroo(x1, v1, x2, v2);
        }


        static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            if (x1 > x2 && v1 > v2)
                return "NO";
            if (x2 > x1 && v2 > v1)
                return "NO";


            var v1List = new List<int>();
            var v2List = new List<int>();

            var v1Aux = x1;
            var v2Aux = x2;

            for (int i = 0; i < 10000; i++)
            {
                v1List.Add(v1Aux);
                v1Aux = v1Aux + v1;

                v2List.Add(v2Aux);
                v2Aux = v2Aux + v2;
            }


            var exist = v1List.Any(_ => v2List.Any(x => x == _));
            if (exist)
            {
                var igual = v1List.Where(_ => v2List.Any(x => x == _)).ToList();
                var indexIsIgual = false;
                foreach (var i in igual)
                {
                    var index = v1List.IndexOf(i);
                    var indexv2 = v2List.IndexOf(i);
                    if (index == indexv2)
                        indexIsIgual = true;
                }

                if (indexIsIgual)
                    return "YES";
                else
                    return "NO";
            }
            else
                return "NO";

        }
    }
}
