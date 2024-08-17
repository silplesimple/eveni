using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class DelegateDemo
    {
        static void Hi() => Console.WriteLine("안녕하세요");

        delegate void SayDelegate();

        static void Main()
        {
            SayDelegate say = Hi;
            say();

            var hi = new SayDelegate(Hi);
            hi();
        }
    }
}
