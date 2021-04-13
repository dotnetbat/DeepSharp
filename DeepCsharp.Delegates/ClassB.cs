namespace DeepCsharp.Delegates
{
  public class ClassB
  {
    public ClassB(ClassA classA)
    {
      classA.DeleA += DeleA;
      classA.DeleA += DeleA;
      classA.DeleA -= DeleA;
      classA.DeleA = DeleB;
      
      classA.EventA += OnEventA;
      classA.EventA += OnEventA;
      classA.EventA -= OnEventA;
      
      // classA.EventA = OnEventA;
    }

    private void OnEventA()
    {
      
    }

    private void DeleA()
    {
      
    }
    
    private void DeleB()
    {
      
    }
  }
}