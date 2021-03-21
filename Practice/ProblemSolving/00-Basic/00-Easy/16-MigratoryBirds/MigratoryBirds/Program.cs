using System;
using System.Collections.Generic;
using System.Linq;

namespace MigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = MigratoryBirds(arr);

            Console.WriteLine(result);

        }

        static int MigratoryBirds(List<int> arr)
        {
            //1 2 3 4 5 4 3 2 1 3 4

            //1 4 4 4 5 3
            var aux = arr.OrderBy(_ => _).GroupBy(_ => _)
                .Select(_ => new 
                {
                    index = _.Key,
                    qtd = _.Count()
                })
                .ToList();

            var maxCount = aux.Max(_ => _.qtd);

            return aux.Where(_ => _.qtd == maxCount).Min(_ => _.index);
        }
    }
}
