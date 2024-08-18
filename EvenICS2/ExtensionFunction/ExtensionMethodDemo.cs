using System;

namespace ExtensionMethodDemo
{
    public static class MyClass
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    class ExtensionMethodDemo
    {
        static void Main()
        {
            string s = "안녕하세요? 확장 메서드......";
            Console.WriteLine(s.Length);
            Console.WriteLine(s.WordCount());
        }
    }
}