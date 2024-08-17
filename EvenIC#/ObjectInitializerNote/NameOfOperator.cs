using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializerNote
{
    internal class NameOfOperator
    {
        static void Main()
        {
            Console.WriteLine("NameToString");
            Console.WriteLine(nameof(NameToString));
        }

        static void NameToString()
        {

        }
    }
}
