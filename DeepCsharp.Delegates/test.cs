namespace DeepCsharp.Delegates
{
  using System;

  public class InterfaceClient
  {
    public static void DoWork()
    {
      IMovable tom = new Person();
      Car tesla = new Car();
      tom.Move();     // Walking
      tesla.Move();   // Driving
    }
  }
 
  interface IMovable
  {
    void Move()
    {
      Console.WriteLine("Walking");
    }
  }
  class Person : IMovable { }
  class Car : IMovable
  {
    public void Move()
    {
      Console.WriteLine("Driving");
    }
  }
}