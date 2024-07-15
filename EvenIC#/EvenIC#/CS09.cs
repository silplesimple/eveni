using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace EvenIC_
{
    internal class CS09
    {
        static void Main(string[] args)
        {
            //int num = 1000;
            //int number = num + 1234;
            //long lNumber = (long)3.141592;
            //Console.WriteLine(lNumber);
            //double dNumber = (double)3.141592;
            //WriteLine(dNumber);
            //int i = 10;
            //int j = 20;
            //int k = i + j;

            //Console.WriteLine(k);
            //decimal i = 3.14M;
            //decimal j = 3.14M;
            //decimal k = i - j;
            //Console.WriteLine($"{k}");

            //long i = 100;
            //long j = 200;
            //long k = i * j;
            //Console.WriteLine($"{k}");

            //double i = 1.5;
            //double j = 0.5;
            //double k = i / j;
            //Console.WriteLine($"{k}");
            //i = 5;
            //j = 3;
            //double n = i % j;
            //Console.WriteLine($"{n}");
            //int f = 10;
            //int s = 5;
            //int r = f % s;
            //Console.WriteLine("{0}%{1}={2}", f, s, r);
            //int a = 5;
            //int b = 3;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine("{0} % {1} ={2}", a, b, (a % b));

            //string connect = "Hello" + "World";
            //string connect1 = "Hi"+" "+"everyone";
            //Console.WriteLine(connect);
            //Console.WriteLine(connect1);
            //Console.WriteLine("{0}+{1}, {2}", 123, 456,123+456);
            Console.WriteLine("Hello" + "World");
            Console.WriteLine("Hi" + " " + "everyone");

            Console.WriteLine("123" + "456");
            Console.WriteLine("123" + 456);
            Console.WriteLine(123 + "456");
            Console.WriteLine(123 + 456);
            Console.WriteLine("123" + true);
            int days = 28;            
            Console.WriteLine("2월달은 " + days+"일입니다.");
            Console.WriteLine("2월달은 " + days.ToString() + "일입니다.");
            Console.WriteLine("2월달은 " + Convert.ToString(days) + "일입니다.");
        }
    }
}
