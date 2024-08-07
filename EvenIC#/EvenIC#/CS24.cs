using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class MyClass()
    {
        public static void MyMethod()
        {
            Console.WriteLine("클래스");
        }
    }
    public class ClassName
    {
        public static void MemberName()
        {
            Console.WriteLine("클래스의 멤버가 호출되어 실행됩니다.");
        }
    }
    internal class CS24
    {
        public class Square
        {
            public static string GetName()
            {
                return "정사각형";
            }
        }
        static void StaticMethod() => Console.WriteLine("{1} 정적메서드");

        void InstanceMethod() => Console.WriteLine("{0} 인스턴스 메서드",1);
        static void Run()
        {
            Console.WriteLine("ClassNote 클래스의 Run 메서드");
        }
        static void Main(string[] args)
        {
            Run();
            CS24.Run();
            string square = Square.GetName();
            Console.WriteLine(square);
            CS24.StaticMethod();
            CS24 my = new CS24();
            my.InstanceMethod();
            MyClass.MyMethod();
            ClassName.MemberName();
            Console.WriteLine("출력됩니다.");
            //Environment.Exit(0);

            Console.WriteLine("출력될까요?");

            //Process.Start("오공정.exe");
            //Process.Start("Explorer.exe", "https://dotnetkorea.com");
            Random random = new Random();
            Console.WriteLine(random.Next());
            int a = random.Next();
            Console.WriteLine(a);
            Console.WriteLine(random.Next(5));
            Console.WriteLine(random.Next(1,10));

        }
    }
}
