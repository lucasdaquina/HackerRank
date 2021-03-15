using System;
using System.Collections.Generic;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = GradingStudents(grades);
        }

        public static List<int> GradingStudents(List<int> grades)
        {
            var result = new List<int>();
            foreach (var g in grades)
            {
                if (g >= 98)
                    result.Add(100);
                else if (g >= 93 && g <= 95)
                    result.Add(95);
                else if (g >= 88 && g <= 90)
                    result.Add(90);
                else if (g >= 83 && g <= 85)
                    result.Add(85);
                else if (g >= 78 && g <= 80)
                    result.Add(80);
                else if (g >= 73 && g <= 75)
                    result.Add(75);
                else if (g >= 68 && g <= 70)
                    result.Add(70);
                else if (g >= 63 && g <= 65)
                    result.Add(65);
                else if (g >= 58 && g <= 60)
                    result.Add(60);
                else if (g >= 53 && g <= 55)
                    result.Add(55);
                else if (g >= 48 && g <= 50)
                    result.Add(50);
                else if (g >= 43 && g <= 45)
                    result.Add(45);
                else if (g >= 38 && g <= 40)
                    result.Add(40);
                else
                    result.Add(g);
            }
            return result;
        }
    }
}
