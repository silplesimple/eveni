using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyNote
{
    class Counter
    {
        private int count;

        public int Count
        {
            get => count;
            set => count = value;
        }

        public void IncreaseCount() => Count++;
    }

    internal class ArrowDemo
    {
        static Counter counter;
        static void Main()
        {
            counter = new Counter();
            counter.IncreaseCount();
            Console.WriteLine($"카운트 : {counter.Count}");
            counter.Count = 2;
            Console.WriteLine(counter.Count);
        }
    }
}
