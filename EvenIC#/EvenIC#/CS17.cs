//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Console;

//namespace EvenIC_
//{
//    internal class CS17
//    {
//        static void Main(string[] args)
//        {
//            //for(int i=0;i<5;i++)
//            //{
//            //    if(i>=0)
//            //    {
//            //        break;
//            //    }
//            //}

//            //int number = 0;
//            //while(true)
//            //{
//            //    Console.WriteLine(++number);

//            //    if(number>=5)
//            //    {
//            //        break;
//            //    }
//            //}
//            //for(int i=0;i<100;i++)
//            //{
//            //    if(i==5)
//            //    {
//            //        break;
//            //    }
//            //    Console.WriteLine($"{(i + 1)}번 반복\t");
//            //}
//            //Console.WriteLine();
//            //int goal = 22;
//            //int sum = 0;

//            //int i = 1;
//            //while (i<=10)
//            //{
//            //    sum += i;

//            //    if(sum>=goal)
//            //    {
//            //        break;
//            //    }

//            //    i++;
//            //}

//            //Console.WriteLine($"1부터 {i}까지의 합은 {sum}이고,목표치{goal}이상을 달성했습니다.");
//            //for(int i=1;i<=5;i++)
//            //{
//            //    if(i%2==0)
//            //    {
//            //        continue;
//            //    }
//            //    Console.WriteLine(i);
//            //}
//            //int sum = 0;
//            //for(int i=1;i<=100;i++)
//            ////{
//            //    if(i%3==0)
//            //    {
//            //        continue;
//            //    }
//            //    sum += i;
//            //}
//            //Console.WriteLine("SUM: {0}", sum);
//            Console.WriteLine("시작");
//        Start:
//            Console.WriteLine("0,a,2 중 하나 입력 : _\b");
//            //int chapter = Convert.ToInt32(Console.ReadLine());
//            //String Input = Console.ReadLine();           
//            int chapter = Convert.ToInt32(Input);
//            //bool success = Int32.TryParse(Input, out chapter);
//            //int chapter = Int32.Parse(Input);
//            if(chapter==97)
//            {
//                goto Chapter1;
//            }
//            else if(chapter==2)
//            {
//                goto Chapter2;
//            }
//            else
//            {
//                goto End;
//            }
//        Chapter1:
//            Console.WriteLine("1장입니다.");
//        Chapter2:
//            Console.WriteLine("2장입니다.");
//            goto Start;

//        End:
//            Console.WriteLine("종료");
//        }
//    }
//}
