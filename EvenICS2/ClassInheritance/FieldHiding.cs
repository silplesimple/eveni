using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldHiding
{
    class Parent
    {
        private string _word;

        protected string Word
        {
            get { return _word; }
            set { _word = value; }
        }

    }

    class Child:Parent
    {
        public void SetWord(string word)
        {
            base.Word = word;
        }
        public string GetWord()
        {
            return Word;
        }

    }
    internal class FieldHiding
    {
        static void Main()
        {
            Child child = new Child();
            child.SetWord("필드 숨기기 및 자식 클래스에만 멤버 상속하기");
            Console.WriteLine(child.GetWord());
        }
    }
}
