using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinallyDemo
{
    internal class TryFinallyDemo
    {
        static void Main()
        {
            Console.WriteLine("[1] 시작");

            try //예외가 발생할 만한 구문이 들어오는 곳
            {
                Console.WriteLine("[2] 실행");
                throw new Exception();//무작정 에러 실행
            }

            finally
            {
                Console.WriteLine("[3] 종료");
            }
        }
    }
}
