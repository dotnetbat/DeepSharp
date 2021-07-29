using System;

namespace DeepCsharp.Misc.Tasks
{
  public class ValueReferenceTypes
  {
    public class Person
    {
      public string name;
      public int age;
    }
    
    public static void Test()
    {
      var p = new Person { name = "Tom", age = 23 };
      
      ChangePerson(p);

      Console.WriteLine(p.name);
      Console.WriteLine(p.age);
    }

    private static void ChangePerson(Person person)
    {
      person.name = "Alice";

      person = new Person
      {
        name = "Bill",
        age = 45
      };
      
      Console.WriteLine(person.name);
    }
  }
}