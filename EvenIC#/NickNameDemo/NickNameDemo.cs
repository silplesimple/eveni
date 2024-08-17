using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickNameDemo
{
    class NickNameDemo
    { 
        static void Main()
        {
            var nick = new NickName();

            nick["박용준"] = "RedPlus";
            nick["김태영"] = "Taeyo";

            Console.WriteLine($"{nick["박용준"]},{nick["김태영"]}");
        }
    }

}
