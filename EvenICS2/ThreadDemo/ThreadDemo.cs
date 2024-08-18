using System;
using System.Threading;

class ThreadDemo
{
    static void Other()
    {
        Console.WriteLine("[?] 다른 작업자 일 실행");
        Thread.Sleep(1000);
        Console.WriteLine("[?] 다른 작업자 일 종료");
    }

    static void Main()
    {
        Console.WriteLine("[1] 메인 작업자 일 시작");

        var other = new Thread(new ThreadStart(Other));
        other.Start();

        Console.WriteLine("[2] 메인 작업자 일 종료");
    }
}
