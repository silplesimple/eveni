using static System.Console;
using static System.Math;
namespace Player
{
    internal class CS21
    {
        static void Main(string[] args)
        {
            //Math
            double a = Math.E;
            int b = -2;
            b = Math.Abs(b);
            double c=Math.Max(a, b);

            //1 기본 사용 방식
            WriteLine(Math.Pow(2, 10));

            //2 using static 지시문으로 줄여서 표현
            WriteLine(Pow(2, 10));
            WriteLine(Max(3, 5));
        }
    }
}
