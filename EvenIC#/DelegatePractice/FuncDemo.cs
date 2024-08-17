using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    internal class FuncDemo
    {
        static void Main()
        {
            Func<int, bool> zero = number => number == 0;
            Console.WriteLine(zero(1234 - 1234));

            Func<int, int> one = n => n + 1;
            Console.WriteLine(one(1));

            Func<int, int, int> two = (x, y) => x + y;
            Console.WriteLine(two(3, 5));
        }
    }
}
