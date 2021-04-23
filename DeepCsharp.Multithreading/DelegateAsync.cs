using System;
using System.Threading;
#nullable enable

namespace DeepCsharp.Multithreading
{
    public class DelegateAsync
    {
        public static void ShowAsyncWork()
        {
            Func<int, int> func = x =>
            {
                Thread.Sleep(500);

                Console.WriteLine("worker");
                
                return ++x;
            };

            var asyncResult = func.BeginInvoke(0, null, null); // will not work on .net core

            Console.WriteLine("main");

            func.EndInvoke(null); // will not work on .net core

            Console.WriteLine("main2");
        }
        
        
    }
}