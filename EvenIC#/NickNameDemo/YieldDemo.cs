using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace NickNameDemo
{
    internal class YieldDemo
    {
        static IEnumerable GetNumbers()
        {
            yield return 1;
            yield return 2;
            for(int i=3;i<=5;i++)
            {
                yield return i;
            }
        }

        static void Main()
        {
            foreach(int num in GetNumbers())
            {
                Console.Write($"{num}\t", num);
            }
            Console.WriteLine();
        }
    }
}
