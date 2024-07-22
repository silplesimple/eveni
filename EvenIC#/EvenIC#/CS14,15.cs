//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Console;

//namespace EvenIC_
//{
//    internal class CS14
//    {
//        static void Main(string[] args)
//        {
//            //int x = 2;
//            //switch(x)
//            //{
//            //    case 1:
//            //        Console.WriteLine("1입니다.");
//            //        break;
//            //    case 2:
//            //        Console.WriteLine("2입니다.");
//            //        break;
//            //}
//            //WriteLine();

//            //Console.WriteLine("정수를 입력하세요.");
//            //int answer = Convert.ToInt32(Console.ReadLine());

//            //switch (answer)
//            //{
//            //    case 1:
//            //        Console.WriteLine("1를 선택했습니다.");
//            //        break;
//            //    case 2:
//            //        Console.WriteLine("2를 선택했습니다.");
//            //        break;
//            //    case 3:
//            //        Console.WriteLine("3를 선택했습니다.");
//            //        break;
//            //    default:
//            //        Console.WriteLine("그냥 찍으셨군요");
//            //        break;
//            //}
//            //WriteLine("가장 좋아하는 프로그래밍 언어는?");
//            //Write("1. C\t");
//            //Write("2. C++\t");
//            //Write("3. C#\t");
//            //Write("4.Java\n");

//            //int choice = Convert.ToInt32(ReadLine());

//            //switch (choice)
//            //{
//            //    case 1:
//            //        WriteLine("C 선택");
//            //        break;
//            //    case 2:
//            //        WriteLine("C++ 선택");
//            //        break;
//            //    case 3:
//            //        WriteLine("C# 선택");
//            //        break;
//            //    case 4:
//            //        WriteLine("java 선택");
//            //        break;
//            //    default:
//            //        WriteLine("C,C++,C#,Java가 아니군요.");
//            //        break;
//            //}
//            //Console.WriteLine("오늘 날씨는 어떤가요? (맑음,흐림,비,눈,....)");
//            //string weather = Console.ReadLine();

//            //switch (weather)
//            //{
//            //    case "맑음":
//            //        Console.WriteLine("오늘 말씨는 맑군요.");
//            //        break;
//            //    case "흐림":
//            //        Console.WriteLine("오늘 날씨는 흐리군요");
//            //        break;
//            //    case "비":
//            //        Console.WriteLine("오늘 날시는 비가 오네요 레전드");
//            //        break;
//            //    case "오늘날씨를내가물어봐야지니가왜물어봐":
//            //        Console.WriteLine("내가 AIxㅂ");
//            //        break;
//            //    default:
//            //        Console.WriteLine("혹시 눈이 내리나요?");
//            //        break;
//            //}

//            //for(int i=0;i<3;i++)
//            //{
//            //    Console.WriteLine("안녕하세욥");
//            //}
//            //for(int i=1;i<=5;i++)
//            //{
//            //    Console.WriteLine("Count : {0},{1}",i,i+1);
//            //}
//            //for (int i = 0; i < 5; i += 2)
//            //{
//            //    Console.WriteLine(i);
//            //}

//            //int n = 3;
//            //int sum = 0;
//            //for(int i=1;i<=n;i++)
//            //{
//            //    sum += i;
//            //}

//            //Console.WriteLine($"1부터 {n}까지의 합: {sum}");

//            //int n = 5;
//            //int sum = 0;

//            //for(int i=1;i<=n;i++)
//            //{
//            //    if(i%2==0)
//            //    {
//            //        sum += i;
//            //    }
//            //}

//            //Console.WriteLine($"1부터 {n}까지의 짝수의 합:{sum}");
//            //int sum = 0;
//            //int a = 0;
//            //for(int i=1;i<=a;i++)
//            //{
//            //    sum += i;
//            //}
//            //Console.WriteLine("1부터 {0}까지 정수의 합 : {0}",a, sum);
//            //for(int i=0;i<5;i++)
//            //{
//            //    Console.Write($"{i + 1}\t");
//            //}
//            //Console.WriteLine("\n");

//            //for(int i=5;i>0;i--)
//            //{
//            //    Console.WriteLine($"{i}\t");
//            //}
//            //int sum = 0;

//            //for(int i=1;i<=100;i++)
//            //{
//            //    if(i%2==0)
//            //    {
//            //        sum += i;
//            //    }
//            //}
//            //Console.WriteLine($"1부터 100까지 짝수의 합:{sum}");
//            //for(int i=1;i<=5;i++)
//            //{
//            //    Console.Write("{0}\t", i);
//            //    if(i%5==0)
//            //    {
//            //        Console.WriteLine();
//            //    }
//            //}
//            //Console.WriteLine();

//            //int sum1 = 0;
//            //for(int i=1;i<=100;i++)
//            //{
//            //    i = 100;
//            //    sum1 += i;
//            //}
//            //Console.WriteLine($"1부터 100까지의 합: {sum1}");

//            //int sum2 = 0;
//            //for(int i=1;i<=100;++i)
//            //{
//            //    i = 100;
//            //    if(i%2==0)
//            //    {
//            //        sum2 += i;
//            //    }
//            //}
//            //Console.WriteLine($"1부터 100까지 짝수의 합:{sum2}");
//            //for(int i=1;i<=5;i++)
//            //{
//            //    for(int j=1;j<=i;j++)
//            //    {
//            //        Console.Write("*");
//            //    }
//            //    Console.WriteLine();
//            //}
//            //for(; ; )
//            //{
//            //    Console.WriteLine("무한 루프");
//            //}
//            //int fact = 0;

//            //for(int i=1;i<4;i++)
//            //{
//            //    Console.Write($"{i}!->");
//            //    fact = 1;
//            //    for(int j=1;j<=i;j++)
//            //    {
//            //        fact = fact * j;
//            //    }
//            //    Console.WriteLine($"{fact,2}");
//            //}
//            for(int i=2;i<=9;i++)
//            {
//                Console.Write($"{i,4}단");
//            }
//            Console.WriteLine();

//            for(int i=2;i<=9;i++)
//            {
//                for(int j=1;j<=9;j++)
//                {
//                    Console.Write($"{j}*{i}={j*i,2} ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}