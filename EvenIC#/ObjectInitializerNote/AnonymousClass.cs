using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializerNote
{
    internal class AnonymousClass
    {
        static void Main()
        {
            var presenter = new { Name = "박용준", Age = 45, Topic = "C#" };
            Console.WriteLine($"{presenter.Name},{presenter.Age},{presenter.Topic}");
        }
    }
}
