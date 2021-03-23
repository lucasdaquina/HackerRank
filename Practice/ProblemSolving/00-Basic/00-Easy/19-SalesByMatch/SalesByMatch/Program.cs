using System;
using System.Linq;

namespace SalesByMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = SockMerchant(n, ar);

            Console.WriteLine(result);
        }

        static int SockMerchant(int n, int[] ar)
        {
            var result = 0;
            var listAr = ar.ToList().GroupBy(_ => _).Select(_ => new { qtd = _.Count(), index = _.Key }).Where(_ => _.qtd > 1).ToList();

            foreach(var a in listAr)
            {
                result = result + a.qtd / 2;
            }
            return result;
        }

    }
}
