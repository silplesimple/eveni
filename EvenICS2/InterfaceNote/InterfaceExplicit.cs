using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNote
{
    interface IDog
    {
        void Eat();
    }
    interface ICat
    {
        void Eat();
    }
    
    class Pet:IDog,ICat
    {
        void IDog.Eat() => Console.WriteLine("Dog Eat");
        void ICat.Eat() => Console.WriteLine("Cat Eat");
    }
    internal class InterfaceExplicit
    {
        static void Main()
        {
            Pet pet = new Pet();
            ((IDog)pet).Eat();
            ((ICat)pet).Eat();

            IDog dog = new Pet();
            dog.Eat();
            ICat cat = new Pet();
            cat.Eat();
        }
    }
}
