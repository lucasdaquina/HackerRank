using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = DiagonalDifference(arr);
        }

        public static int DiagonalDifference(List<List<int>> arr)
        {
            var sumFirstDiagonal = 0;
            var sumSecondDiagonal = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    if (i == j)
                        sumFirstDiagonal = sumFirstDiagonal + arr[i][j];
                    if (i == (arr.Count - j - 1))
                        sumSecondDiagonal = sumSecondDiagonal + arr[i][j];
                }
            }
            return sumFirstDiagonal - sumSecondDiagonal > 0 ?
                            sumFirstDiagonal - sumSecondDiagonal :
                            (sumFirstDiagonal - sumSecondDiagonal) * -1;

        }
    }
}
