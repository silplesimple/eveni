﻿//using System;
//using System.Threading;
//using System.Threading.Tasks;

//class AsyncAwaitDescription
//{
//    static void Main()
//    {
//        Task.Run(() => DoPrint());
//        Console.WriteLine("[?] async await 사용 예제");
//        Thread.Sleep(1);
//    }

//    static async void DoPrint()
//    {
//        await PrintNumberAsync();
//    }

//    static async Task PrintNumberAsync()
//    {
//        await Task.Run(() =>
//        {
//            for (int i = 0; i < 300; i++)
//            {
//                Console.WriteLine(i + 1);
//            }
//        });
//    }
//}