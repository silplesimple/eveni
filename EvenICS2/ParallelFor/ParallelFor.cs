using System;
using System.Threading.Tasks;

class ParallelFor
{
    static void Main()
    {
        Parallel.For(0, 200_000, (i) => { Console.WriteLine(i); });
    }
        
}