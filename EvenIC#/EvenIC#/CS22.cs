using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

class MyException:Exception
{
    public MyException(string message):base(message)
    {

    }
}
namespace Player
{
    struct Point
    {
        public int X;
        public int Y;
    }
    struct PlayerState
    {
        public int Age;
        public string Name;
        public string[] Games;
    }

    struct BusinessCard
    {
        public string Name;
        public int Age;
    }

    
    internal class CS22
    {
        static void Print(string name, int age)
            => Console.WriteLine($"{name}은(는) {age}살입니다");

        static void Print(BusinessCard biz)
        {
            Console.WriteLine($"이름:{biz.Name},나이:{biz.Age}");
        }
        
        static void Main(string[] args)
        {
            Point point;
            PlayerState player;
            BusinessCard biz;
            TimeSpan dday = Convert.ToDateTime("2024-12-25") - DateTime.Now;
            Console.WriteLine($"{DateTime.Now.Year}년도 크리스마스는 {(int)dday.TotalDays}일 남음");
            char a = 'A'; char b = 'a';
            char c = '1';char d = '\t';
            string unique = Guid.NewGuid().ToString();
            Console.WriteLine($"유일한 값:{unique}");

            Console.WriteLine($"유일한 값:{Guid.NewGuid().ToString("D")}");
            if(Char.IsUpper(a))
            {
                Console.WriteLine("{0}은(는) 대문자", a);
            }
            if(Char.IsLower(b))
            {
                Console.WriteLine("{0}은(는) 소문자", b);
            }
            if (Char.IsNumber(c))
            {
                Console.WriteLine("{0}은(는) 숫자형", c);
            }
            if (Char.IsWhiteSpace(d))
            {
                Console.WriteLine("{0}은(는) 공백 문자", d);
            }

            Console.WriteLine(Char.ToLower(a));
            Console.WriteLine(Char.ToUpper(b));

            string s = "abc";
            if (Char.IsUpper(s[0]))
            {
                Console.WriteLine("첫 글자가 대문자로 시작합니다.");

            }
            else if (Char.IsLower(s[0]))
            {
                Console.WriteLine("첫 글자가 소문자로 시작합니다.");
            }

            Console.WriteLine(Char.MinValue);
            Console.WriteLine(Char.MaxValue);


            //지난 시간 구하기
            TimeSpan times = DateTime.Now - Convert.ToDateTime("2001-10-04");
            Console.WriteLine($"내가 지금까지 며칠 살아 왔는지?{(int)times.TotalDays}");
            if(DateTime.TryParse("2019/12/25",out var xmas))
            {
                Console.WriteLine(xmas);
            }
            Console.WriteLine(GetDateTimeFromYearIyHourNumber(1));
            DateTime getDateTimeFromYearIyHourNumber = GetDateTimeFromYearIyHourNumber(1);
            Console.WriteLine(GetDateTimeFromYearIyHourNumber(8760 / 2));
            Console.WriteLine(GetDateTimeFromYearIyHourNumber(8760));
            biz.Name = "백승수";
            biz.Age = 17;
            Print(biz.Name, biz.Age);
            Print(biz);
            BusinessCard[] names = new BusinessCard[2];
            names[0].Name = "이세영"; names[0].Age = 102;
            names[1].Name = "권경민"; names[1].Age = 31;
            
            for(int i=0;i<names.Length;i++)
            {
                Print(names[i].Name, names[i].Age);
            }
            //point.X = 100;
            //point.Y = 200;
            //String typeName = nameof(point.X);
            //Console.WriteLine(typeName);
            //Console.WriteLine(nameof(typeName));
            //Console.WriteLine($"X:{point.X},Y:{point.Y}");

            //try Catch, struct
            //try
            //{
            //    Console.WriteLine("나이가 어떻게 되시나요?");
            //    player.Age = Int32.Parse(ReadLine());
            //    //if(player.Age>25)
            //    //{
            //    //    throw new MyException("반오십이 넘었어요");
            //    //}                
            //    Console.WriteLine("이름을 알려주세요.");
            //    player.Name = ReadLine();
            //    Console.WriteLine("하고 계신 게임이 몇개인가요?");
            //    int gameIndex = int.Parse(ReadLine());
            //    player.Games = new string[gameIndex];
            //    for(int i=0;i<player.Games.Length;i++)
            //    {
            //        Console.WriteLine("게임에 이름을 입력해주세요");
            //        player.Games[i] = ReadLine();
            //    }
            //    Console.Write($"플레이어의 나이: {player.Age}\n");
            //    Console.Write($"플레이어의 이름: {player.Name}\n");
            //    for(int i=0;i<player.Games.Length;i++)
            //    {
            //        Console.WriteLine($"플레이어의 게임 목록: {player.Games[i]}");
            //    }
                
            //    Console.WriteLine(player);

            //}
            //catch(FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch(OutOfMemoryException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch(IOException e )
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch(ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

                        
            //나이가 몇살이신가요?

            //이름이 뭔가요?
                //게임을 몇개 하시나요?
            //나이를 입력하고
            //이름을 입력하고
            //게임을 입력하고 

            
        }
        static DateTime GetDateTimeFromYearIyHourNumber(int number)
        {
            return (new DateTime(2019, 1, 1, 0, 0, 0)).AddHours(--number);
        }
    }
}
