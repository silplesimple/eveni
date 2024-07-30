using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace EvenIC_
{
    internal class CS19
    {
        //static void Show()
        //{
        //    Console.WriteLine("Hello World");
        //}
        //static int Plus(int a)
        //{
        //    a += 1;
        //        return a;
        //}
        //static void Hi()
        //{            
        //    Console.WriteLine("안녕하세요.");
        //}
        //static void ShowMessage(string message)
        //{
        //    Console.WriteLine(message);
        //}
        //static string GetString()
        //{
        //    return "반환값(return value)";
        //}
        //static int SquareFunction(int x)
        //{
        //    int r = x * x;
        //    return r;
        //}
        //static double GetSum(double x, double y)
        //{
        //    double r = x + y;
        //    return r;
        //}
        //static int Max(int x,int y)
        //{
        //    return (x > y) ? x : y;
        //}

        //static int Min(int x,int y)
        //{
        //    //if(x<y)
        //    //{
        //    //    return x;
        //    //}
        //    //else
        //    //{
        //    //    return y;
        //    //}
        //    return (x < y) ? x : y;
        //}

        ///// <summary>
        ///// 두 수를 더하여 그 결과값을 변환시켜주는 함수
        ///// </summary>
        ///// <param name="a">첫 번째 매개변수</param>
        ///// <param name="b">두 번째 매개변수</param>
        ///// <returns>a+b 결과</returns>
        //static int AddNumbers(int a,int b)
        //{
        //    return a + b;
        //}
        ///// <summary>
        ///// 로그를 남겨주는 함수
        ///// </summary>
        ///// <param name="message"> 남긴 메세지</param>
        ///// <param name="level">레벨</param>
        //static void Log(string message,byte level=1)
        //{
        //    Console.WriteLine($"{message},{level}");
        //}
        //static void Sum(int first,int second)
        //{
        //    Console.WriteLine(first + second);
        //}
        //static void GetNumber(int number)
        //{
        //    Console.WriteLine($"Int32 : {number}");
        //}

        //static void GetNumber(float number)
        //{
        //    Console.WriteLine($"Int64:{number1}");
        //}

        //static void Hi()
        //{
        //    Console.WriteLine("안녕하세요.");
        //}

        //static void Hi(string msg)
        //{
        //    Console.WriteLine(msg);
        //}

        static int Fact(int n)
        {
            return (n > 1) ? n * Fact(n - 1) : 1;
        }

        static int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        static int FactorialFor(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static int MyPower(int num, int cnt)
        {
            if (cnt == 0)
            {
                return 1;
            }
            return num * MyPower(num, --cnt);
        }

        static void Log(string message) => Console.WriteLine(message);
        static bool IsSame(string a, string b) => a == b;
        static void Main(string[] args)
        {
            //Show();
            // Hi();Hi();Hi();
            //ShowMessage("매개변수");
            //ShowMessage("Parameter");
            //string returnValue = GetString();
            //Console.WriteLine(returnValue);
            //int r = SquareFunction(2);
            //Console.WriteLine(r);
            //double result = GetSum(3.0, 0.14);
            //Console.WriteLine(result);
            //Console.WriteLine(Max(3, 5));
            //Console.WriteLine(Min(-3, -5));
            //int a = 3;
            //int b = 5;
            //int c = AddNumbers(a, b);
            //Console.WriteLine($"{a}+{b}={c}");
            //Log("디버그");
            //Log("에러", 4);
            //Sum(10, 20);
            //Sum(first:10,second:20);
            //Sum(second: 20, first: 10);
            //GetNumber(1234);
            //GetNumber(12.3f);
            //Hi();
            //Hi("하윙");
            //Console.WriteLine(4 * 3 * 2 * 1);
            Console.WriteLine(FactorialFor(4));
            Console.WriteLine(Factorial(4));
            Console.WriteLine(Fact(4));
            Console.WriteLine(MyPower(2, 2));

            //Log("함수 축약");
            //Console.WriteLine(IsSame("A", "A"));
        }
        
    }
}
