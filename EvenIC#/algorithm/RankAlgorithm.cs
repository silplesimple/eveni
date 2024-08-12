using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    internal class RankAlgorithm
    {
        static void Main()
        {
            int[] scores = { 90, 87, 100, 95, 80 };
            int[] rankings = Enumerable.Repeat(1, 5).ToArray();

            for(int i=0;i<scores.Length;i++)
            {
                rankings[i] = 1;
                for(int j=0;j<scores.Length;j++)
                {
                    if (scores[i] < scores[j])
                    {
                        rankings[i]++;
                    }
                }
            }

            for(int i=0;i<scores.Length;i++)
            {
                Console.WriteLine($"{scores[i],3}점 : {rankings[i]}등");
            }
        }
    }
}
