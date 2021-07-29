using System;

namespace DeepCsharp.Misc.Tasks
{
  class Exception1 : Exception
  {
  }

  class Exception2 : Exception1
  {
  }

  class Exception3 : Exception2
  {
  }

  class Exception4 : Exception3
  {
  }

  public class Test
  {
    public void TestMethod()
    {
      try
      {
        try
        {
          throw new Exception1();
        }
        catch (Exception e)
        {
          throw new Exception2();
        }
        // catch (Exception1 e)
        // {
        //   throw new Exception3();
        // }
        finally
        {
          throw new Exception4();
        }
      }
      catch (Exception e)
      {
        throw;
        //throw e;
      }
    }
  }
}