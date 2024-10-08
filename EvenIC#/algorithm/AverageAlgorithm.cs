﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    internal class AverageAlgorithm
    {
        static void Main()
        {
            int[] data = { 90, 65, 78, 50, 95 };
            int sum = 0;
            int count = 0;

            for(int i=0;i<data.Length;i++)
            {
                if (data[i] >= 80 && data[i]<=95)
                {
                    sum += data[i];
                    count++;
                }
            }

            double avg = 0.0f;
            if(sum!=0&&count !=0)
            {
                avg = sum / (double)count;
            }

            Console.WriteLine($"80점 이상 95점 이하인 자료 평균:{avg:0.00}");
        }
    }
}
