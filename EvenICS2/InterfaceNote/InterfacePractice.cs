using System;

public interface IRepository
{
    void Get();
}

public class Repository :IRepository
{
    public void Get()
    {
        Console.WriteLine("Get() 메서드를 구현해야 합니다.");
    }
}

class InterfacePratice
{
    static void Main()
    {
        IRepository repository = new Repository();
        repository.Get();
    }
}