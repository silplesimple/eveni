using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    internal class CountAlgorithm
    {
        static void Main()
        {
            var numbers = Enumerable.Range(1, 1_000).ToArray();
            int count = default;

            for(int i=0;i<numbers.Length;i++)
            {
                if (numbers[i]%13==0)
                {
                    count++;
                }
            }

            Console.WriteLine($"1부터 1000까지 정수 중 13의 배수 개수:{count}");
        }
    }
}
