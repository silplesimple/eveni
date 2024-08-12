using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class CountFunc
    {
        static void Main()
        {
            bool[] blns = { true, false, true, false, true };

            Console.WriteLine(blns.Count());
            Console.WriteLine(blns.Count(bln => bln == true));
            Console.WriteLine(blns.Count(bln => bln == false));
        }
    }
}
