using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace NickNameDemo
{
    class YieldReturn
    {
        static IEnumerable MultiData()
        {
            yield return "Hello";
            yield return "World";
            yield return "C#";
        }

        static void Main()
        {
            foreach(var item in MultiData())
            {
                Console.WriteLine(item);
            }
        }
    }
}
