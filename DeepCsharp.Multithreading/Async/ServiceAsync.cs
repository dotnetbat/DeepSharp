using System.Threading;
using System.Threading.Tasks;

namespace DeepCsharp.Multithreading.Async
{
  public class ServiceAsync
  {
    public Task<int> Method1()
    {
      Throttle();
      
      return Task.FromResult(1);
    }
    
    public Task<int> Method2()
    {
      Throttle();
      
      return Task.FromResult(2);
    }
    
    public Task<int> Method3()
    {
      Throttle();
      
      return Task.FromResult(3);
    }
    
    private void Throttle()
    {
      Thread.Sleep(1000);
    }
  }
}