using System;

namespace DeepCsharp.Delegates
{
  class Program
  {
    static void Main(string[] args)
    {
      var a = new ClassA();
      var b = new ClassB(a);

      a.RaiseDelegateA();
    }
  }
}