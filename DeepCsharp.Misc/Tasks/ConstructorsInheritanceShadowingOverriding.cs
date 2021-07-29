using System;

namespace DeepCsharp.Misc.Tasks
{
  public static class ConstructorsInheritanceShadowingOverriding
  {
    public static void ConsoleWrite()
    {
      // A b = new B();
      // b.ShadowingMethod();
      // b.Poly();
      //var c = new B();

      var c = new C();
      A a = c;
      
      a.ShadowingMethod();
      a.Poly();
      c.ShadowingMethod();
    }
  }

  public class A
  {
    static A()
    {
      Console.WriteLine("SA");
    }

    internal A()
    {
      Console.WriteLine("PA");
    }

    public void ShadowingMethod()
    {
      Console.WriteLine("ShadowingMethod");
    }

    public virtual void Poly()
    {
      Console.WriteLine("ABVirtual");
    }
  }

  public class B : A
  {
    static B()
    {
      Console.WriteLine("SB");
    }

    public B()
    {
      Console.WriteLine("PB");
    }

    public new void ShadowingMethod()
    {
      Console.WriteLine("NewShadowingMethod");
    }

    public override void Poly()
    {
      //base.Poly();

      Console.WriteLine("ABOverride");
    }
  }

  public class C : B
  {
    public new void ShadowingMethod()
    {
      Console.WriteLine("NewNewShadowingMethod");
    }
  }
}