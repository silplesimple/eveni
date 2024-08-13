using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldClass
{
    internal class VariableScope
    {
        static string globalVariable = "전역 변수";

        static void Main()
        {
            string localVariable = "지역 변수";
            Console.WriteLine(localVariable);
            Console.WriteLine(globalVariable);
            Test();
        }

        static void Test() => Console.WriteLine(globalVariable);
    }
}
