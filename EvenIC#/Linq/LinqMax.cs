using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class LinqMax
    {
        static void Main()
        {
            var numbers = new List<int>() { 1, 2, 3 };

            int max = numbers.Max();

            Console.WriteLine($"{nameof(numbers)} 컬렉션의 최댓값:{max}");

        }
    }
}
