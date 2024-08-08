using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    internal class PatternMatchingWithIf
    {
        static void Main()
        {
            PrintStars(null);
            PrintStars("하나");
            PrintStars(5);
        }

        private static void PrintStars(object o)
        {
            if(o is null)
            {
                return;
            }
            if(o is string)
            {
                return;
            }
            if(!(o is int number))
            {
                return;
            }
            Console.WriteLine(new String('*',number));
        }
    }
}
