using System;
using System.Linq;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            PlusMinus(arr);
        }

        static void PlusMinus(int[] arr)
        {
            decimal qtd = (decimal)arr.Count();
            decimal qtdPositive = 0M;
            decimal qtdNegative = 0M;
            decimal qtdZero = 0M;
            foreach (var ar in arr)
            {
                if (ar == 0)
                    qtdZero = qtdZero + 1;
                else if (ar > 0)
                    qtdPositive = qtdPositive + 1;
                else
                    qtdNegative = qtdNegative + 1;
            }


            decimal p = qtdPositive / qtd;
            decimal n = qtdNegative / qtd;
            decimal z = qtdZero / qtd;


            var resultP = decimal.Round(p, 6);
            Console.WriteLine(resultP);
            var resultN = decimal.Round(n, 6);
            Console.WriteLine(resultN);
            var resultZ = decimal.Round(z, 6);
            Console.WriteLine(resultZ);

        }

    }
}
