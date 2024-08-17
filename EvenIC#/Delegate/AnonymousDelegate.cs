using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class AnonymousDelegate
    {
        delegate void SayDelegate();
        static void Main()
        {
            SayDelegate say = delegate ()
            {
                Console.WriteLine("반갑습니다.");
            };
            say();
        }
    }
}
