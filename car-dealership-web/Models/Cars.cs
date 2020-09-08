using System;

namespace Dealership.Models {

  public class Car
  {

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
    public string MakeModel {get; set;}
    public int Price{get; set;}
    public int Miles{get;set;}

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

   

    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }
  }

}