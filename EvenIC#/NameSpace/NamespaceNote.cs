using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimSyunGyu;

namespace  Foo
{
    public class Car
    {
        public void Go() => Console.WriteLine("[1] Foo 네임스페이스의 Car클래스 호출");
    }
}
namespace Bar
{
    public class Car
    {
        public void Go() => Console.WriteLine("[2] Bar 네임스페이스의 Car 클래스 호출");
    }

}
namespace SimSyunGyu
{
    public class Car
    {
        public void Go() => Console.WriteLine("[3] Bar 네임스페이스의 Car 클래스 호출");
    }
}
namespace NameSpace
{
    internal class NamespaceNote
    {
        static void Main()
        {
            Foo.Car fooCar = new Foo.Car();
            fooCar.Go();
            Bar.Car barCar = new Bar.Car();
            barCar.Go();
            SimSyunGyu.Car SyunGyuCar = new SimSyunGyu.Car();
            SyunGyuCar.Go();
        }
    }
}
