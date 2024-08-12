using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinallyDemo
{
    internal class TryCatchFinallyDemo4
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
            catch(Exception ex)
            {
                Console.WriteLine($"예외 발생:{ex.Message}");
            }
            finally
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}
