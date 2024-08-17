using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{    
    internal class ParameterRef
    {
        static void Main()
        {
            int num = 10;
            Console.WriteLine($"[1] {num}");

            Do(ref num);

            Console.WriteLine($"[3]{num}");
        }

        static void Do(ref int num)
        {
            num = 20;
            Console.WriteLine($"[2]{num}");
        }
    }
}
