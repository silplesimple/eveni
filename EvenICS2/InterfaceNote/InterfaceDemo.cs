using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNote
{
    interface IBattery
    {
        string GetName();
    }
    class Good:IBattery
    {
        public string GetName() => "Good";
    }

    class Bad : IBattery
    {
        public string GetName() => "Bad";
    }

    class IcCar
    {
        private IBattery _battery;

        public IcCar(IBattery battery)
        {
            _battery = battery;
        }

        public void Run() => Console.WriteLine(
            "{0} 배터리를 장착한 자동가 달립니다.", _battery.GetName());
    }

    internal class InterfaceDemo
    {
        static void Main(string[] args)
        {
            var good = new IcCar(new Good());
            good.Run();
            new IcCar(new Bad()).Run();
        }
    }
}
