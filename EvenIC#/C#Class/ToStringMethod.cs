using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Class
{
    class My { }

    class Your
    {
        public override string ToString()
        {
            return "이건 너야";
        }
    }

    internal class ToStringMethod
    {
        static void Main()
        {
            My my = new My();
            Console.WriteLine(my);

            Your your = new Your();
            Console.WriteLine(your);
        }
    }
}
