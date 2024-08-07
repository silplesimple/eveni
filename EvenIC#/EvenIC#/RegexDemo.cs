using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Player
{
    internal class RegexDemo
    {
        static void Main()
        {
            string email = "abcd@aaa.com";
            Console.WriteLine(IsEmail(email));

            object x = 1234;
            if(x is int)
            {
                Console.WriteLine($"{x}는 정수형으로 변환이 가능합니다.");
            }
            x = 1234;
            string s = x as string;
            Console.WriteLine(s == null ? "null" : s);
        }

        private static bool IsEmail(string email)
        {
            bool result = false;

            Regex regex=new Regex(
                @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)" +
            @"(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            result = regex.IsMatch(email);

            return result;
        }
    }
}
