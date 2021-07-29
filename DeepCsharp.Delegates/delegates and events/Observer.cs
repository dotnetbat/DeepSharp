namespace DeepCsharp.Delegates.delegates_and_events
{
  public class Observer
  {
    public Observer(Publisher publisher)
    {
      publisher.PublisherDelegate += DelegateMethod1;
      publisher.PublisherDelegate += DelegateMethod1;
      publisher.PublisherDelegate -= DelegateMethod1;

      publisher.PublisherDelegate = DelegateMethod2;

      publisher.PublisherEvent += OnPublisherEvent;
      publisher.PublisherEvent += OnPublisherEvent;
      publisher.PublisherEvent -= OnPublisherEvent;

      // publisher.PublisherEvent = OnEventParent; // wrong

      // publisher.PublisherDelegate?.Invoke();  // possible
      // publisher.PublisherEvent?.Invoke(); // wrong
    }

    private void OnPublisherEvent()
    {

    }

    private void DelegateMethod1()
    {

    }

    private void DelegateMethod2()
    {

    }
  }
}