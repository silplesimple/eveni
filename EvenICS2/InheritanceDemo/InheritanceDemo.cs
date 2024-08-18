using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Parent
    {
        public void Foo() => Console.WriteLine("부모 클래스의 멤버 호출");
    }

    class Child : Parent
    {
        public void Bar() => Console.WriteLine("자식 클래스의 멤버 호출");
    }

    internal class InheritanceDemo
    {
        static void Main()
        {
            var child = new Child();
            child.Foo();
            child.Bar();
        }
    }
}
