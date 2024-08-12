using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinallyDemo
{
    internal class TryCatchFinallyDemo3
    {
        static void Main()
        {
            int x = 5;
            int y = 0;
            int r;

            try
            {
                r = x / y;
                Console.WriteLine($"{x}/{y}={r}");
            }
            catch
            {
                Console.WriteLine("예외가 발생했습니다.");
            }
            finally
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}
