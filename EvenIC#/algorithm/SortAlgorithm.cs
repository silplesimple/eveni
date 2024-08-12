using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    internal class SortAlgorithm
    {
        static void Main()
        {
            int[] data = { 3, 2, 1, 5, 4 };
            int N = data.Length;

            for(int i=0;i<N-1;i++)
            {
                for(int j=i+1;j<N;j++)
                {
                    if (data[i] > data[j])
                    {
                        int temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }

            for(int i=0;i<N;i++)
            {
                Console.Write($"{data[i]}\t");
            }
            Console.WriteLine();
        }
    }
}
