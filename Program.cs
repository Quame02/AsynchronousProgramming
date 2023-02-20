// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Asynchronous_Programing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main method started......");
            //Async_Await.NonAsyncMethod();
            Async_Await.AsyncMethod();
            Console.WriteLine("Main method end......");
            Console.ReadKey();
        }
    }
}


