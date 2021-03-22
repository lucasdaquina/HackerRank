using System;
using System.Collections.Generic;
using System.Linq;

namespace BillDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            BonAppetit(bill, k, b);
        }

        static void BonAppetit(List<int> bill, int k, int b)
        {
            var itemToRemove = bill[k];
            bill.Remove(itemToRemove);

            var sumBill = bill.Sum() / 2;

            if (sumBill == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - sumBill);
            }

        }


    }
}
