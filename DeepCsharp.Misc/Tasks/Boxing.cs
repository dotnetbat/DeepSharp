using System;

namespace DeepCsharp.Misc.Tasks
{
  public class Boxing
  {
    public static void Test()
    {
      int i = 5;

      object j = i;

      i++;
      //j++;

      long a = (long)j;

      Console.WriteLine(i);
    }
  }
}