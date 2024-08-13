using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Class
{
    internal class ClassDemo
    {
        static void Main()
        {
            ClassOne.Hi();
            ClassTwo.Hi();

            ClassTwo ct = new ClassTwo();
            ct.Hello();
        }
    }
}
