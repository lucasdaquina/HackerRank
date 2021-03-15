using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = BirthdayCakeCandles(candles);
        }

        public static int BirthdayCakeCandles(List<int> candles)
        {
            var unit = candles.Max();
            var qtd = candles.Where(_ => _ == unit).Count();
            return qtd;
        }
    }
}
