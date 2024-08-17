using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializerNote
{
    class Catalog
    {
        public string this[int index]
        {
            get
            {
                return (index % 2 == 0) ? $"{index}:짝수반환" : $"{index}:홀수 반환";
            }
        }
    }
    internal class IndexerNoter
    {
        static void Main()
        {
            Catalog catalog = new Catalog();
            Console.WriteLine(catalog[0]);
            Console.WriteLine(catalog[1]);
            Console.WriteLine(catalog[2]);
        }
    }
}
