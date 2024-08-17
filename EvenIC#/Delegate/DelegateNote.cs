using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class DelegateNote
    {
        delegate void SayPointer();

        static void Hello() => Console.WriteLine("Hello Delegate");

        static void Main()
        {
            SayPointer sayPointer = new SayPointer(Hello);

            sayPointer();
            sayPointer.Invoke();
        }
    }
}
