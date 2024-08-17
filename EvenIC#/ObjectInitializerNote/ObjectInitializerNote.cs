using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializerNote
{
    internal class ObjectInitializerNote
    {
        static void Main()
        {
            Person p1 = new Person();
            p1.Name = "백승수";
            p1.Age = 21;
            Console.WriteLine($"이름:{p1.Name},나이:{p1.Age},타입:{p1.Type}");

            Person p2 = new Person() { Name = "이세영", Age = 99 };
            Console.WriteLine($"이름:{p2.Name} 나이:{p2.Age},타입:{p2.Type}");
        }
    }
}
