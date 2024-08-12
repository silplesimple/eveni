using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class LinqAverage
    {
        static void Main()
        {
            int[] numbers={ 1,3,4};

            double average = numbers.Average();
            Console.WriteLine($"{nameof(numbers)} 배열 요소의 평균:{average:#,###.##}");

        }
    }
}
