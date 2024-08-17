using static System.Console;

public class DestructorTest
{
    public DestructorTest() //생성자
    {
        WriteLine("[1] 생성");
    }

    public void Run() //메서드
    {
        WriteLine("[2] 실행");
    }

    ~DestructorTest() //소멸자
    {
        WriteLine("[3] 소멸");
    }
}

class ConstructorToDestructor
{
    static void Main()
    {
        DestructorTest test = new DestructorTest();
        test.Run();
        //GC.Collect();
    }
}