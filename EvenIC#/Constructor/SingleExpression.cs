using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class SingleExpression
    {
        static int AddAge(int age) => age + 1;

        static void Main() => Console.WriteLine(AddAge(100));
    }
}
