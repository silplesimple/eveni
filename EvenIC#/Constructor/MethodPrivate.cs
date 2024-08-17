using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Dog
    {
        public void NowEat()
        {
            Console.WriteLine("[1] 밥을 먹는다.");
            this.Digest();
        }

        private void Digest()
        {
            Console.WriteLine("[2] 소화를 시킨다.");
        }
    }

    internal class MethodPrivate
    {
        static void Main()
        {
            Dog dog = new Dog();
            dog.NowEat();
        }
    }
}
