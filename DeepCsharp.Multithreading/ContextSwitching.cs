using System;
using System.Threading;

namespace DeepCsharp.Multithreading
{
    public class ContextSwitching
    {
        public static void ShowSimpleExample()
        {
            var thread = new Thread(WritUsingNewThread);
            
            thread.Start();
            
            for (var i = 0; i < 1000; i++)
            {
                Console.Write($" a{i} ");
            }
        }

        private static void WritUsingNewThread()
        {
            for (var i = 0; i < 1000; i++)
            {
                Console.Write($" z{i} ");
            }
        }
    }
}