using System;
using DeepCsharp.Multithreading.Async;

namespace DeepCsharp.Multithreading
{
  class Program
  {
    static void Main(string[] args)
    {
      // var threadService = new ThreadService();
      // threadService.StartThread();

      // ContextSwitching.ShowSimpleExample();

      //DelegateAsync.ShowAsyncWork();

      TaskClient.CalcAsync();
    }
  }
}