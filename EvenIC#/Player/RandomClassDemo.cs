using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    internal class RandomClassDemo
    {
        static void Main(string[] args)
        {
            Console.Write("이번 주의 로또");
            Random ran = new Random();
            int[] arr = new int[6];
            int temp = 0;
            for(int i=0;i<6;i++)
            {
                temp = ran.Next(45) + 1;
                bool flag = false;
                if(i>0&&i<6)
                {
                    for(int j=0;j<=i;j++)
                    {
                        if (arr[j]==temp)
                        {
                            flag = true;
                        }
                    }
                }
                if(flag)
                {
                    --i;
                } 
                else
                {
                    arr[i] = temp;
                }
            }
            for(int i=0;i<6;i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.Write("\n");
        }
    }
}
