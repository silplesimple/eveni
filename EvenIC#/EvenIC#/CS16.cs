//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Console;
//namespace EvenIC_
//{
//    internal class CS16
//    {
//        static void Main(string[] args)
//        {
//            int count = 0;
//            while (count < 3)
//            {
//                Console.WriteLine("안녕하세요.");
//                count++;
//            }
//            int i = 1;
//            while (i <= 5)
//            {
//                Console.WriteLine("카운트 : {0}", i);
//                i++;
//            }
//            int index = 5;
//            while (index > 0)
//            {
//                Console.WriteLine($"안녕하시오. {index}");
//                index--;
//            }
//            const int N = 100;
//            int sum = 0;

//            int i = 1;
//            while (i <= N)
//            {
//                sum += i;
//                i++;
//            }

//            Console.WriteLine($"1부터 {N}까지의 합:{sum}");
//            int sum = 0;

//            int i = 1;
//            while (i <= 100)
//            {
//                if (i % 2 == 0)
//                {
//                    sum += i;
//                }
//                i++;
//            }

//            Console.WriteLine($"1부터 100까지 짝수의 합: {sum}");
//            int first = 0;
//            int second = 1;

//            while (second <= 144)
//            {
//                Console.WriteLine(second);
//                int temp = first + second;
//                first = second;
//                second = temp;
//            }
//            int count = 0;
//            do
//            {
//                Console.WriteLine("안녕하세요.");
//                count++;
//            }
//            while (count < 3);
//            int sum = 0;

//            int i = 1;
//            do
//            {
//                sum += i;
//                i++;
//            } while (i <= 5);

//            Console.WriteLine($"합계 : {sum}");
//            int sum = 0;

//            int i = 1;
//            do
//            {
//                if (i % 3 == 0 && i % 4 == 0)
//                {
//                    sum += i;
//                }
//                i++;
//            } while (i <= 100);

//            Console.WriteLine(sum);
//            string[] names = { "C#", "ASP.NET" };
//            foreach (string name in names)
//            {
//                Console.WriteLine(name);
//            }
//            string str = "ABC123";

//            foreach (float a in str)
//            {
//                Console.Write($"{a}\t");
//            }
//            Console.WriteLine();
//            var str = "ABC123";

//            foreach (var c in str)
//            {
//                Console.Write($"{c}\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}
