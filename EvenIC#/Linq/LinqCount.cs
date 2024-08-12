using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace Linq
{
    internal class LinqCount
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3 };
            int count = numbers.Count();

            Console.WriteLine($"{nameof(numbers)} 배열 개수:{count}");
        }
    }
}
