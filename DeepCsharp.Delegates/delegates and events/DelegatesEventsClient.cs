namespace DeepCsharp.Delegates.delegates_and_events
{
  public class DelegatesEventsClient
  {
    public static void DoClientWork()
    {
      var publisher = new Publisher();
      var observer = new Observer(publisher);

      publisher.RaisePublisherDelegate();
    }
  }
}