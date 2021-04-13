namespace DeepCsharp.Delegates
{
  public class ClassA
  {
    public delegate void DelegateA();

     public DelegateA DeleA;
     public event DelegateA EventA;
    
    public void RaiseDelegateA()
    {
      DeleA!.Invoke();
    }
    
    public void RaiseEventA()
    {
      EventA!.Invoke();
    }
  }
}