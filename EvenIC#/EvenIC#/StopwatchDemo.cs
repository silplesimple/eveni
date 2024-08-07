using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    internal class StopwatchDemo
    {
        static void Main()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            LongTimeProcess();
            timer.Stop();

            Console.WriteLine("경과 시간 : {0}밀리초", timer.Elapsed.TotalMilliseconds);

            Console.WriteLine("경과 시간:{0}초", timer.Elapsed.Seconds);
        }

        private static void LongTimeProcess()
        {
            //3초간 대기:Thread.Sleep() 메서드로 현재 프로그램 3초간 대기
            Thread.Sleep(3000);
        }
    }
}
