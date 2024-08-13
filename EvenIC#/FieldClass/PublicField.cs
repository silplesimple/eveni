using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldClass
{
        class Category
        {
            public string CategoryName;
        }
    internal class PublicField
    {
        static void Main()
        {
            Category book = new Category();
            book.CategoryName = "책";
            Console.WriteLine(book.CategoryName);
        }
    }
}
