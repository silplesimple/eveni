using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    internal class stringIsNullOrEmpty
    {
        static void Main(string[] args)
        {
            var str = "";
            str = String.Empty;

            if(str==null||str=="")
            {
                Console.WriteLine($"{nameof(str)}변수 값은 null 또는 빈 값(empty)입니다.");
            }

            if(string.IsNullOrEmpty(str))
            {
                Console.WriteLine($"{nameof(str)}변수 값은 null 또는 빈 값(Empty)입니다.");

            }

            var hi1 = "안녕";
            var hi2 = "하세요";
            hi1 += hi2;
            Console.WriteLine($"{hi1}");
            Console.WriteLine(String.Concat(hi1, hi2));
            Console.WriteLine(String.Format("{0} {1} {0}", hi1, hi2));
            str = " Abc Def Fed Cba";
            string[] strArray = str.Trim().Split(' ');
            foreach(string s in strArray)
            {
                Console.WriteLine(s);
            }

            StringBuilder builder = new StringBuilder();

            builder.Append("January\n");
            builder.Append("February\n");
            builder.AppendLine("March");
            string a = builder.ToString();
            Console.WriteLine(builder);
            Console.WriteLine(a);

            var message = new StringBuilder()
                .AppendFormat("{0} 클래스를 사용한 ", nameof(StringBuilder))
                .Append("메서드 ")
                .Append("체이닝 ")
                .ToString()
                .Trim();
            Console.WriteLine(message);
            StringBuilder sb = new StringBuilder();

            sb.Append("<script>");
            sb.AppendFormat("window.alert(\"{0}\");", DateTime.Now.Year);
            sb.AppendLine("</script>");
            sb.ToString();

            Console.WriteLine(sb);

            DateTime start = DateTime.Now;

            string msg = "";
            for(int i=0;i<10000;i++)
            {
                msg += "안녕하세요.";
            }

            DateTime end = DateTime.Now;
            double exec = (end - start).TotalMilliseconds;
            Console.WriteLine(exec);

            
        }
    }
}
