using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridePractice
{
    public class ParrentClass
    {
        public virtual void Hi1() => Console.WriteLine("기본:안녕하세요");
        public void Hi2() => Console.WriteLine("기본:반갑습니다.");
        public void Hi3() => Console.WriteLine("기본:또 만나요.");
    }
    public class ChildClass : ParrentClass
    {
        public override void Hi1() => Console.WriteLine("파생 : 안녕하세요");
        public new void Hi2() => Console.WriteLine("파생:반갑습니다");
        public new void Hi3() => base.Hi3();
        
    }

    class Parent
    {
        public void Say() => Console.WriteLine("부모가 말하다.");
        public void Hi() => Console.WriteLine("부모가 인사하다");
        public virtual void Walk() => Console.WriteLine("부모가 걷다");
    }

    class Child:Parent
    {
        public void Say() => Console.WriteLine("자식이 말하다");
        public new void Hi() => Console.WriteLine("자식이 인사하다");
        public override void Walk() => Console.WriteLine("자식이 걷다");
        
    }
    internal class MethodOverridePractice
    {
        static void Main()
        {
            ChildClass child = new ChildClass();
            child.Hi1();
            child.Hi2();
            child.Hi3();

            Child baby = new Child();
            baby.Say();
            baby.Hi();
            baby.Walk();
        }
    }
}
