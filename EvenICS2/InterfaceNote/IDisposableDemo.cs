using System;

class IDisposableDemo
{
    static void Main()
    {
        Console.WriteLine("[1] 열기");
        using(var t=new Toilet())
        {
            Console.WriteLine("[2] 사용");
        }
    }
}

public class Toilet:IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("[3] 닫기");
    }
}