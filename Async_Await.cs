using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asynchronous_Programing
{
    public static class Async_Await
    {
        public static void NonAsyncMethod()
        {
            Console.WriteLine("NonAsync method started......");
            Thread.Sleep(TimeSpan.FromSeconds(10));
            Console.WriteLine("\nLets see how this works");
            Console.WriteLine("NonAsync method end.....");
        }

        public async static void AsyncMethod()
        {
            Console.WriteLine("Async method started......");
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("\nLets see how this works");
            Console.WriteLine("Async method end.....");
        }
    }
}