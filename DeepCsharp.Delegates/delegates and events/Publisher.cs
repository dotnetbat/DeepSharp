namespace DeepCsharp.Delegates.delegates_and_events
{
  public class Publisher
  {
    public delegate void DelegateParent();

    public DelegateParent PublisherDelegate;
    public event DelegateParent PublisherEvent;

    public void RaisePublisherDelegate()
    {
      PublisherDelegate!.Invoke();
    }

    public void RaisePublisherEvent()
    {
      PublisherEvent!.Invoke();
    }
  }
}