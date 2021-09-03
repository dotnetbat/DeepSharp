using System.Threading;

namespace DeepCsharp.Multithreading.Async
{
  public class Service
  {
    public int Method1()
    {
      Throttle();
      
      return 1;
    }
    
    public int Method2()
    {
      Throttle();
      
      return 2;
    }
    
    public int Method3()
    {
      Throttle();
      
      return 3;
    }

    private void Throttle()
    {
      Thread.Sleep(1000);
    }
  }
}