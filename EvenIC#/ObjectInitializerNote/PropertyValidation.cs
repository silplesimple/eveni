using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializerNote
{
    class Car
    {
        public string Name { get; private set; }
        public Car(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                //빈 값이면 강제로 ArgumentException 예외 발생
                throw new ArgumentException();
            }
            this.Name = name;
        }
    }

    internal class PropertyValidation
    {
        static void Main()
        {
            Car car = new Car("자동차");
            Console.WriteLine(car.Name);
        }
    }
}
