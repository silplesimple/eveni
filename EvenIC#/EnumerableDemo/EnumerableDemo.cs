using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableDemo
{
    internal class EnumerableDemo
    {
        static void Main()
        {
            var numbers = Enumerable.Range(1, 5);
            foreach(var n in numbers)
            {
                Console.Write("{0}\t", n);
            }
            Console.WriteLine();

            var SameNumbers = Enumerable.Repeat(-1, 5);
            foreach (var n in SameNumbers)
            {
                Console.Write("{0}\t", n);
            }
            Console.WriteLine();
        }
    }
}
