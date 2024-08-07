using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum RPS
{
    가위=1,
    바위=2,
    보=3
}
namespace Player
{
    internal class RockPaperScissors
    {
        static void Main()
        {
            int iRandom = 0;
            int iSelection = 0;
            string[] choice = { "가위", "바위", "보" };

            iRandom = (new Random()).Next(1, 4);

            Console.Write("1(가위),2(바위),3(보) 입력:\b");
            iSelection = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n 사용자:{0}", choice[iSelection - 1]);
            Console.WriteLine(" 컴퓨터 :{0}\n", choice[iRandom - 1]);
            RPS rps = (RPS)iSelection;
            if (iSelection==iRandom)
            {
                Console.WriteLine("비김");
            }            
            else
            {
                switch (rps)
                {
                    case RPS.가위:Console.WriteLine((iRandom == 3) ? "승" : "패");
                        break;
                    case RPS.바위:Console.WriteLine((iRandom==1)?"승":"패");
                        break;
                    case RPS.보:Console.WriteLine((iRandom == 2) ? "승" : "패");
                        break;
                    
                }
            }
        }
        
    }
}
