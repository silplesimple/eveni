using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public partial class Person
    {
        public void Print() => Console.WriteLine($"{Name}:{Age}");
    }

    class PartialClass
    { 
        static void Main()
        {
            Person person = new Person();

            person.Name = "C#";
            person.Age = 20;

            person.Print();

        }
    }

}
