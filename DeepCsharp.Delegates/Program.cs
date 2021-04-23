using System;
using DeepCsharp.Delegates.co_and_contra_variance;
using DeepCsharp.Delegates.delegates_and_events;

namespace DeepCsharp.Delegates
{
  class Program
  {
    static void Main(string[] args)
    {
      DelegatesEventsClient.DoClientWork();
      
      CoContravarianceClient.DoClientWork();
      
      int[] array = new int[10];

      Func<int>[] arrayOfDataProviders = new Func<int>[10];

      for (int i = 0; i < 10; i++)
      {
        arrayOfDataProviders[i] = () => i;
      }

      int j = 0;
      foreach (var dataProvider in arrayOfDataProviders)
      {
        array[j++] = dataProvider();
      }

      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine(array[i]);
      }
    }
  }
}