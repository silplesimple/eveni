using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializerNote
{
    internal class AnonymousType
    {
        static void Main()
        {
            var data = new { Id = 1, Name = "익명 형식" };
            Console.WriteLine($"{data.Id}-{data.Name}");
        }
    }
}
