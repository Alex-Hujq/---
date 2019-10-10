using System;

namespace 第八章
{
  public class CarInfoEventArgs : EventArgs
  {
    public CarInfoEventArgs(string car)
    {
      this.Car = car;
    }

    public string Car { get; private set; }
  }

  public class cardealer
  {
    public event EventHandler<CarInfoEventArgs> NewCarInfo;

    public cardealer()
    {

    }

    public void NewCar(string car)
    {
      Console.WriteLine("CarDealer, new car {0}", car);
      if (NewCarInfo != null)
      {
        NewCarInfo(this, new CarInfoEventArgs(car));
      }
    }
  }
}
