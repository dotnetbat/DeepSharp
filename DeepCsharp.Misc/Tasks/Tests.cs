using System;

namespace DeepCsharp.Misc.Tasks
{
  public class Tests
  {
    public static void TaskFromAnatolii()
    {
      int[] array = new int[10];

      Func<int>[] arrayOfDataProviders = new Func<int>[10];

      for (int i = 0; i < 10; i++)
      {
        arrayOfDataProviders[i] = () => i;
      }

      int j = 0;
      foreach (var dataProvider in arrayOfDataProviders)
      {
        array[j++] = dataProvider();
      }

      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine(array[i]);
      }
    }

    // public ActionResult Index()
    // {
    //     var user = _userDataService.GetByEmail(User.Identity.Name); // 2s
    //     var subscriptions = _subscriptionDataService.GetByUserId(user.Id); //6s
    //     var invoices = _invoiceDataService.GetByUserId(user.Id); //4s
    //
    //     return Json(new CombinedUserModel()
    //     {
    //       DisplayName = $"{user.FirstName} {user.LastName}",
    //       subscriptions = subscriptions.Select(x => _mapper.Map<SubscriptionViewModel>(x)).ToList(),
    //       invoices = invoices.Select(x => _mapper.Map<InvoiceViewModel>(x)).ToList()
    //     };
    // }
  }
}