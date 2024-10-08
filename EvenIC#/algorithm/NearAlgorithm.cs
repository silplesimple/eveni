﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    internal class NearAlgorithm
    {
        static void Main()
        {
            int Abs(int number) => (number < 0) ? -number : number;

            int min = int.MaxValue;

            int[] numbers = { 0b1010, 0x14, 0b11110, 0x1B, 0b10001 };
            int target = 25;
            int near = default;

            for(int i=0;i<numbers.Length;i++)
            {
                int abs = Abs(numbers[i] - target);
                if(abs<min)
                {
                    min = abs;
                    near = numbers[i];
                }
            }

            var minimum = numbers.Min(m => Math.Abs(m - target));
            var closet = numbers.First(c => Math.Abs(target - c) == minimum);
            Console.WriteLine($"{target}와/과 가장 가까운 값(식):{closet}(차이:{minimum})");
            Console.WriteLine($"{target}와/과 가장 가까운 값(문):{near}(차이:{min})");

        }
    }
}
