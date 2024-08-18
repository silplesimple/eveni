using System;

namespace Dul.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dul.Creator.GetName());

            Console.WriteLine(Dul.math.Abs(-1234));

            Console.WriteLine("안녕하세요".CutStringUnicode(6));
        }
    }
}
