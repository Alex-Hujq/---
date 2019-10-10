using System;
using System.Windows;

namespace 第八章
{
  public class consumer : IWeakEventListener
  {
    private string name;

    public consumer(string name)
    {
      this.name = name;
    }

    public void NewCarIsHere(object sender, CarInfoEventArgs e)
    {
      Console.WriteLine("{0}: car {1} is new", name, e.Car);
    }

    bool IWeakEventListener.ReceiveWeakEvent(Type managerType, object sender, EventArgs e)
    {
      NewCarIsHere(sender, e as CarInfoEventArgs);
      return true;
    }


  }
}
