using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DeepCsharp.Multithreading.Async
{
  public class TaskClient
  {
    public static int Calc()
    {
      var service = new Service();

      var stopwatch = new Stopwatch();
      
      stopwatch.Start();
      
      var one = service.Method1();
      var two = service.Method2();
      var three = service.Method3();

      stopwatch.Stop();
      
      Console.WriteLine(stopwatch.Elapsed);
      
      return one + two + three;
    }
    
    public static int CalcAsync()
    {
      var service = new Service();

      var stopwatch = new Stopwatch();
      
      stopwatch.Start();
      
      var one = Task.Run(service.Method1);
      var two = Task.Run(service.Method2);
      var three = Task.Run(service.Method3);

      Task.WaitAll(one, two, three);
      
      stopwatch.Stop();
      
      Console.WriteLine(stopwatch.Elapsed);
      
      return one.Result + two.Result + three.Result;
    }
    
    public static int CalcAsync2()
    {
      var service = new ServiceAsync();

      var stopwatch = new Stopwatch();
      
      stopwatch.Start();
      
      var one = service.Method1();
      var two = service.Method2();
      var three = service.Method3();

      Task.WaitAll(one, two, three);
      
      stopwatch.Stop();
      
      Console.WriteLine(stopwatch.Elapsed);
      
      return one.Result + two.Result + three.Result;
    }
  }
}