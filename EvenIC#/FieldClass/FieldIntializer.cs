using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldClass
{
    class Say
    {
        private string message = "안녕하세요";

        public void Hi()
        {
            this.message = "반갑습니다.";
            Console.WriteLine(this.message);
        }
    }
    internal class FieldIntializer
    {
        static void Main()
        {
            Say say = new Say();
            say.Hi();
        }
    }
}
