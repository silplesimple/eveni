using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAn
{
    class Vehicle { }
    class Car : Vehicle { }

    class Airplane : Vehicle { }
    class IsAn
    {
        static void Main()
        {
            Vehicle vehicle = new Vehicle();
            Vehicle car = new Car();
            Vehicle airplane = new Airplane();

            Console.WriteLine($"{vehicle},{car},{airplane}");
        }
    }
}
