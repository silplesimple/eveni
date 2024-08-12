using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace Linq
{
    internal class LinqSum
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3 };
            int sum = numbers.Sum();

            Console.WriteLine($"numbers 배열 요소의 합:{sum}");
        }
    }
}
