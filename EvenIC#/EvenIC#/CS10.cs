using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace EvenIC_
{
    internal class CS10
    {
        static void Main(string[] args)
        {
            //var name = "C#";
            //var version = 8.0;
            //Console.WriteLine($"{name} {version}");
            //var i = 100;
            //var j = 200;
            //Console.WriteLine($"처음 :{i},{j}");

            //var temp = i;
            //i = j;
            //j = temp;
            //Console.WriteLine($"변경 : {i} ,{j}");

            //int num = 10;
            //num = num + 1;
            //num += 1;
            //Console.WriteLine(num);

            //int num1 = 10;
            //num1 -= num1 - 1;
            //num1 -= 1;
            //Console.WriteLine(num1);

            //int x = 3;
            //int y = 3;
            //x = x + 2;
            //y += 2;
            //Console.WriteLine($"x : {x},y: {y}");

            //int a = 3;
            //int b = 5;
            //b += a;
            //Console.WriteLine(b);

            //b -= a;
            //Console.WriteLine(b);

            //num = 100;
            //++num;
            //Console.WriteLine($"{++num}, {num++}");

            //i = 3;
            //j = ++i;
            //Console.WriteLine(j);
            //x = 3;
            //y = x++;//먼저 넣은다음 계산이 되어서 3이 저장된다.
            //Console.WriteLine(y);
            //y += y;
            //Console.WriteLine(y);
            //Console.WriteLine(x);
            //Console.WriteLine("aaa" == "AAA");

            //Console.WriteLine(true && true);
            //Console.WriteLine(true && false);
            //Console.WriteLine($"true && true->{true && true}");
            //Console.WriteLine($"true && false->{true && false}");
            //Console.WriteLine($"false && true - > {false && true}");
            //Console.WriteLine($"false && true ->{false && false}");
            //Console.WriteLine($"true || true->{true || true}");
            //Console.WriteLine($"true || false->{true || false}");
            //Console.WriteLine($"false||true->{false||true}");
            //Console.WriteLine($"false||false->{false || false}");

            //Console.WriteLine($"!true -> {!true}");
            //Console.WriteLine($"!false -> {!false}");
            //var iInt32=3;
            //var jInt32= 5;
            //var rBool = false;

            //rBool = (i == 3) && (j != 3);
            //WriteLine($"i= {iInt32} ,j= {jInt32}");
            //WriteLine($"i==3 && j!= 3 => {rBool}");

            //rBool = (iInt32 != 3) || (jInt32 == 3);
            //Console.WriteLine(rBool);
            //var i = 3;
            //var j = 5;
            //var r = false;

            //r = (i == 3) && (j != 3);
            //WriteLine(r);

            //r = (i != 3) || (j == 3);
            //WriteLine(r);

            //r = (i >= 5);//i가 5를 넘지 않기 때문에 false
            //WriteLine("{0}", !r);//true

            //WriteLine(false && true);
            //WriteLine((1 == 1) || (1 != 1));
            //WriteLine(!(1 == 1));

            //byte x = 0b1010;//10
            //byte y = 0b1100;//12

            //x AND y를 이진수로 표현 -> 십진수로 2칸 잡고 표현
            //Console.WriteLine($" {Convert.ToString(x & y,2)}-> {x & y,2}");
            //byte x = 0b1010;
            //byte y = 0b1100;
            //WriteLine($"{Convert.ToString(x, 2)}->{x}");
            //WriteLine($"| {Convert.ToString(y, 2)}->{y}");

            //WriteLine($" {Convert.ToString(x | y, 2)}->{x | y,2}");
            //byte x = 0b_1010;
            //byte y = 0b_1100;
            //WriteLine($" {Convert.ToString(x,2)}->{x}");
            //WriteLine($" ^{Convert.ToString(y, 2)}->{y}");

            //WriteLine($" {Convert.ToString(x ^ y, 2).PadLeft(4, '0')}->{x ^ y,2}");
            //byte x = 0b_0000_1010;

            //WriteLine($"~{Convert.ToString(x,2).PadLeft(8,'0')}->{x,3}");

            //WriteLine($" {Convert.ToString((byte)~x, 2).PadLeft(8, '0')}->{~x,3}");
            var x = Convert.ToInt32("1010", 2);
            var y = Convert.ToInt32("0110", 2);

            var and = x & y;
            Console.WriteLine($"{and} : {Convert.ToString(and, 2).PadLeft(4,'0')}");

            var or = x | y;
            Console.WriteLine($"{or} : {Convert.ToString(or, 2)}");

            var xor = x ^ y;
            Console.WriteLine($"{xor}:{Convert.ToString(xor, 2)}");

            var not = ~x; //2의 보수법에 따라서 1010 +1 그리고 부호를 -로 -1011 => -11
            Console.WriteLine($"{not} : {Convert.ToString(not, 2)}");
            
        }
    }
}
