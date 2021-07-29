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
    }
  }
}