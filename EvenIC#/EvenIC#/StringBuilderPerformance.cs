using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    internal class StringBuilderPerformance
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;

            StringBuilder sb = new StringBuilder();
            for(int i=0;i<10000;i++)
            {
                sb.Append("안녕하세요.");
            }

            DateTime end = DateTime.Now;
            Double mns = (end - start).TotalMilliseconds;
            Console.WriteLine(mns);
        }
    }
}
