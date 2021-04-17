namespace DeepCsharp.Collections
{
  using System;
  using System.Collections;
  using System.Collections.Generic;

  internal class Program
  {
    public static void Main(string[] args)
    {
      var a = new Dictionary<string, int>();

      a["a"] = 4;
      a["a"] = 4;

      var b = new Hashtable();
      
      b.Add(5, 6);

      var lazy = new Lazy<Hashtable>();
      
      
    }
  }
}