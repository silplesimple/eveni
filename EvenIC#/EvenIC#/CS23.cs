using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Player
{
    enum Priority
    {
        High,
        Normal,
        Low
    }
    enum Align
    {
        Top=0,
        Bottom=2,
        Left=4,
        Right= 8
    }

    enum Weekday
    { 
        Sunday,Monday,Tuesday,Wednesday,Thursday,Friday, Saturday
    }

    enum CoffeeSize
    {
        Small,Medium,Large
    }

    enum Animal
    {
        Mouse,Cow,Tiger,Rabbit,Dragon,Snake
    }

    enum CrazyAnimal
    {
        Horse,
        Sheep=5,
        Monkey
    }

    internal class CS23
    {
        static void Main(string[] args)
        {
            //전경색
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Blue");
            Console.ResetColor();

            //배경색
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red");
            Console.ResetColor();
            Priority high = Priority.High;
            Priority normal = Priority.Normal;
            Priority low = Priority.Low;

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{high},{normal},{low}");
            Console.ResetColor();

            int a = (int)Align.Top;
            Align top = (Align)a;
            Console.Write($"{a},{top}\n");

            Animal animal = Animal.Tiger;
            Console.WriteLine(animal);

            if(animal==Animal.Tiger)
            {
                Console.WriteLine("호랑이");
            }

            string animalName = Animal.Tiger.ToString();            
            Console.WriteLine(animalName);

            Animal animal1 = Animal.Dragon;
            int num = (int)animal1;
            string str = animal1.ToString();
            Console.WriteLine($"Animal.Dragon:{num},{str}");
            Console.WriteLine((int)CrazyAnimal.Monkey);
            CrazyAnimal crazyAnimal = CrazyAnimal.Monkey;
            crazyAnimal = (CrazyAnimal)2;

            switch(crazyAnimal)
            {
                case CrazyAnimal.Horse:
                    Console.WriteLine("미친말");
                    break;
                case CrazyAnimal.Sheep:
                    Console.WriteLine("미친양");
                    break;
                case CrazyAnimal.Monkey:
                    Console.WriteLine("미친원숭이");
                    break;
                default:
                    Console.WriteLine("미친 동물 없음");
                    break;
            }

            Type cc = typeof(ConsoleColor);
            string[] colors = Enum.GetNames(cc);

            foreach(var color in colors)
            {
                Console.WriteLine(color);
            }

            Type animalType = typeof(CrazyAnimal);
            string[] Animals = Enum.GetNames(animalType);

            foreach(var animals in Animals)
            {
                Console.WriteLine(animals);
            }

            string choiceColor = "Red";

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), choiceColor);
            Console.WriteLine("Red");
            Console.ResetColor();
            
        }
    }
}
