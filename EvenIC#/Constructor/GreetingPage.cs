using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Greeting
    {
        private string message = "사이트에 오신 것을 환영합니다";
        public void Say() => Console.WriteLine(this.message);
    }

    internal class GreetingPage
    {
        static void Main() => (new Greeting()).Say();        
    }
}
