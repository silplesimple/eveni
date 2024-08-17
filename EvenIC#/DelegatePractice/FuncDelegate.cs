using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    internal class FuncDelegate
    {
        static void Main()
        {
            Console.WriteLine(Add(3, 5));

            Func<int, int, string> AddDelegate = Add;
            Console.WriteLine(AddDelegate(3, 5));

            Func<int, int, string> AddLambda = (a, b) => (a + b).ToString();
            Console.WriteLine(AddLambda(3, 5));
        }
        static string Add(int a, int b) => (a + b).ToString();
    }
}
