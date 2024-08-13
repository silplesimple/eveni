using System;
using Korea.Seoul;
using In= Korea.Incheon;
namespace Korea
{
    namespace Seoul
    {
        public class Car
        {
            public void Run() => Console.WriteLine("서울 자동차가 달립니다.");
        }

    }

    namespace Incheon
    {
        public class Car
        {
            public void Run() => Console.WriteLine("인천 자동차가 달립니다");
        }

    }
}

namespace NameSpace
{
    internal class NamespaceDescription
    {
        
        static void Main()
        {
            Korea.Seoul.Car s = new Korea.Seoul.Car();
            s.Run();
            Korea.Incheon.Car i = new Korea.Incheon.Car();
            i.Run();

            Car seoul = new Car();
            seoul.Run();
            In.Car ic = new In.Car();
            ic.Run();
        }
    }
}

