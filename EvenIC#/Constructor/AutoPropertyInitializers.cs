using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class AutoPropertyInitializers
    {
        public static string Name { get; set; } = "길벗";
        static void Main()
        {
            Console.WriteLine(Name);
        }
    }
}
