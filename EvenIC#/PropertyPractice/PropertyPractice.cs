using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPractice
{
    class Fish
    {
        public int Weight { get; set; } = 50;
        public void Feed(int weight) => Weight += weight;
    }

    internal class PropertyPractice
    {
        static void Main()
        {
            var fish = new Fish();
            fish.Weight = 10;
            fish.Feed(15);
            Console.WriteLine(fish.Weight);
        }
    
    }
}
