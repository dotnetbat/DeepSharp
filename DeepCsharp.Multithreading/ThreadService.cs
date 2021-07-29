using System;
using System.Threading;

namespace DeepCsharp.Multithreading
{
  public class ThreadService
  {
    public void StartThread()
    {
      var thread = new Thread(DoInternalWork);

      thread.Start();

      var autoResetEvent = new AutoResetEvent(true);
      var mutex = new Mutex();
      var sema = new Semaphore(3, 3);
      var timer = new Timer(DoInternalWork);

      lock (thread)
      {

      }
    }

    private static void DoInternalWork(object obj)
    {
      Console.WriteLine(Thread.CurrentThread.Name);
    }
  }

  public struct A
  {
    public A(int ii, int jj)
    {
      i = 6;
      j = 7;
    }

    public int i;
    public int j;
  }
}