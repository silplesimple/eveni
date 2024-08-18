
using System;

namespace PolymorphisDemo
{
    public abstract class Animal
    {
        public abstract string Cry();
    }

    public class Dog : Animal
    {
        public override string Cry() => "멍멍멍";

    }

    public class Cat : Animal 
    {
        public override string Cry() => "야옹";        
        
    }

    public class Trainer
    {
        public void DoCry(Animal animal)
        {
            Console.WriteLine("{0}", animal.Cry());
        }

    }

    class PolymorphidmDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Dog()).Cry());
            Console.WriteLine((new Cat()).Cry());

            Animal dog = new Dog();
            Console.WriteLine(dog.Cry());
            Animal cat = new Cat();
            Console.WriteLine(cat.Cry());

            Trainer trainer = new Trainer();
            trainer.DoCry(new Dog());
            trainer.DoCry(new Cat());
        }
    }



}