using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    internal class CS25
    {
        static void Main(string[] args)
        {
            string s1 = "안녕하세요";
            String s2 = "반갑습니다";
            Console.WriteLine($"{s1} {s2}");
            s1 = "안녕" + "하세요";
            s2 = String.Concat("반갑", "습니다");
            Console.WriteLine($"{s1}{s2}");

            char[] charArray = { 'A', 'B', 'C' };
            String str = new String(charArray);
            Console.WriteLine(str);
            string userName = "RedPlus";
            string userNameInput = "redPlus";

            if(userName.ToLower()==userNameInput.ToLower())
            {
                Console.WriteLine("[1] 같습니다.");
            }

            if(string.Equals(userName,userNameInput,StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("[2] 같습니다");
            }

            s1 = "Gilbut";
            s2 = "gilbut";

            if(s1==s2)
            {
                Console.WriteLine("같다");
            }
            else
            {
                Console.WriteLine("다르다.");
            }
            if(s1.Equals(s2,StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("같다");
            }

            string s = "Hello.";
            char[] ch = s.ToCharArray();
            Console.WriteLine(ch);

            for(int i=0;i<ch.Length;i++)
            {
                Console.Write($"{ch[i]}\t");
            }

            string src = "Red,Green,Blue";
            string[] colors = src.Split(',');
            Console.WriteLine($"{colors[0]},{colors[1]},{colors[2]}");

            
        }
    }
}
