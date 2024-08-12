using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinallyDemo
{
    internal class TryCatchFinallyDemo2
    {
        static void Main()
        {
            int x = 5;
            int y = 0;
            int r;

            r = x / y;

            Console.WriteLine($"{x}/{y}={r}");
        }
    }
}
