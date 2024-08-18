using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassToString
{
    class Person
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public override string ToString() => $"[Person 클래스:{this.name}]";
    }
    internal class ClassToString
    {
        static void Main()
        {
            Person person = new Person("박용준");
            Console.WriteLine(person);
        }
    }
}
