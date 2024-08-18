//using System;
//using System.Net.Http;
//using System.Runtime.InteropServices;
//using System.Threading.Tasks;

//class AsyncAwaitSimple
//{
//    static async Task DoAsync()
//    {
//        using (var client=new HttpClient())
//        {
//            var r = await client.GetAsync(
//                "https://dotnetnote.azurewebsites.net/api/WebApiDemo");
//            var c = await r.Content.ReadAsStringAsync();

//            Console.WriteLine(c);
//        }
//    }

//    static async Task Main()
//    {
//        await DoAsync();
//    }
//}
