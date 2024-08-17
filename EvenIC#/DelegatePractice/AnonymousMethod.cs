﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    public class Print
    {
        public static void Show(string msg) => Console.WriteLine(msg);
    }

    internal class AnonymousMethod
    {
        public delegate void PrintDelegate(string msg);
        public delegate void SumDelegate(int a, int b);
        static void Main()
        {
            Print.Show("안녕하세요");

            PrintDelegate pd = new PrintDelegate(Print.Show);
            pd("반갑습니다");

            PrintDelegate am = delegate (string msg)
            {
                Console.WriteLine(msg);
            };
            am("또 만나요.");

            SumDelegate sd = delegate (int a, int b) { Console.WriteLine(a + b); };
            sd(3, 5);//8
        }
    }
}
