using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class MinAndMax
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3 };
            int min = arr.Min();
            int max = arr.Max();

            Console.WriteLine($"최솟값:{min},최댓값:{max}");
        }
    }
}
