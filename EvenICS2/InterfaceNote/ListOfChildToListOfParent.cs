
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfChildToListOfParent
{
    interface A { }

    class B : A { }

    class ListOfChildToListOfParent
    {
        static void Main()
        {
            List<A> convertAll = (new List<B>()).ConvertAll(x => (A)x);
            List<A> astoff = (new List<B>()).Cast<A>().ToList();

            Console.WriteLine(convertAll);
            Console.WriteLine(astoff);
        }
    }
}