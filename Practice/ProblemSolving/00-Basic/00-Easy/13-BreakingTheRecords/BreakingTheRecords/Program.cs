using System;

namespace BreakingTheRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))            ;
            int[] result = BreakingRecords(scores);
        }

        static int[] BreakingRecords(int[] scores)
        {
            var bestRecord = -1;
            var worstRecord = -1;

            var countBest = 0;
            var countWorst = 0;

            var firstBest = true;
            var firstWorst = true;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > bestRecord || bestRecord == -1)
                {
                    bestRecord = scores[i];
                    if (!firstBest)
                    {
                        countBest++;
                    }
                    else
                    {
                        firstBest = false;
                    }
                }

                if (scores[i] < worstRecord || worstRecord == -1)
                {
                    worstRecord = scores[i];
                    if (!firstWorst)
                    {
                        countWorst++;
                    }
                    else
                    {
                        firstWorst = false;
                    }
                }
            }

            return new int[] { countBest, countWorst };

        }
    }
}
