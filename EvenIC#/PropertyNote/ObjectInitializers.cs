using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyNote
{
    public class PersonMan
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public PersonMan()
        {

        }
        public PersonMan(string name,int age)
        {
            Name = name;
            Age = age;
        }
    }

    internal class ObjectInitializers
    {
        static void Main()
        {
            PersonMan pp = new PersonMan();
            pp.Name = "이세영";
            pp.Age = 100;

            PersonMan pc = new PersonMan("백승수", 21);

            PersonMan pi = new PersonMan { Name = "권경민", Age = 30 };
            Console.WriteLine($"{pi.Name},{pi.Age}");


        }
    }
}
