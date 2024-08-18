using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    public class Parent
    {
        public string Word { get; set; }
        public Parent(string word)
        {
            this.Word = word;
        }
    }
    public class Child: Parent
    {
        public Child():this("[1] 매개변수가 없는 생성자 실행") { }

        public Child(string message) : base(message) { }
        public void Say() => Console.WriteLine(base.Word);
    }
    internal class ConstructorInheritance
    {
        static void Main()
        {
            (new Child()).Say();
            (new Child("[2] 매개변수가 있는 생성자 실행")).Say();
        }
    }
}
