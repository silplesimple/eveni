using System;

interface IPerson
{
    void Work();
}

class Person:IPerson
{
    public void Work() => Console.WriteLine("일을 합니다.");
}

class InterfaceExam
{
    static void Main()
    {
        Person person = new Person();
        person.Work();
    }
}
