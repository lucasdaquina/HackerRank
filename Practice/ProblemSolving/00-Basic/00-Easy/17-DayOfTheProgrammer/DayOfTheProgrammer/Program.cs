using System;

namespace DayOfTheProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = DayOfProgrammer(year);

            Console.WriteLine(result);
        }

        static string DayOfProgrammer(int year)
        {
            var dateReturn = new DateTime();
            if (year == 1918)
            {
                return $"26.09.1918";
                //dateReturn = new DateTime(year, 1, 1).AddDays(223);
            }
            else if (year >= 1919)
            {
                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                {
                    //dateReturn = new DateTime(year, 1, 1).AddDays(255);
                    return $"12.09.{year}";
                }
                else
                {
                    //dateReturn = new DateTime(year, 1, 1).AddDays(255);
                    return $"13.09.{year}";
                }
            }
            else
            {
                if (year % 4 == 0)
                {
                    //dateReturn = new DateTime(year, 1, 1).AddDays(255);
                    return $"12.09.{year}";
                }
                else
                {
                    //dateReturn = new DateTime(year, 1, 1).AddDays(255);
                    return $"13.09.{year}";
                }
            }

            //return $"{dateReturn.Day.ToString("dd")}.{dateReturn.Month.ToString().PadLeft(2, '0')}.{dateReturn.Year}";
        }
    }
}
