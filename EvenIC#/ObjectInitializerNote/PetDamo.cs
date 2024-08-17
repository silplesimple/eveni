using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializerNote
{
    class Pet
    {
        public int Weight { get; set; }

        public void Feed(int weight)
        {
            Weight += weight;
        }
    }
    internal class PetDamo
    {
        static void Main()
        {
            Pet pet = new Pet();
            pet.Weight = 50;
            pet.Feed(10);
            Console.WriteLine(pet.Weight);
        }
    }
}
