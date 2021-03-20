using System;
using System.Collections.Generic;
using System.Linq;

namespace DivisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = DivisibleSumPairs(n, k, ar);

            Console.WriteLine(result);
        }

        static int DivisibleSumPairs(int n, int k, int[] ar)
        {
            var lista = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                for (int j = i +1; j < n; j++)
                {
                    var auxLista = new List<int>();
                    auxLista.Add(ar[i]);
                    auxLista.Add(ar[j]);
                    lista.Add(auxLista);
                }

            }

            return lista.Where(_ => (_.Sum() % k) == 0).Count();
        }

    }
}
