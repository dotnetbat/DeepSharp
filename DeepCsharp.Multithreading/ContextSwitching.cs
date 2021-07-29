using System;
using System.Threading;

namespace DeepCsharp.Multithreading
{
  public class ContextSwitching
  {
    public static void ShowSimpleExample()
    {
      var thread = new Thread(WriteUsingNewThread)
      {
        Name = "SuperThread"
      };

      thread.Start();

      for (var i = 0; i < 1000; i++)
      {
        Console.Write($" a{i} ");
      }
    }

    private static void WriteUsingNewThread()
    {
      for (var i = 0; i < 1000; i++)
      {
        Console.Write($" z{i} ");
      }
    }
  }
}