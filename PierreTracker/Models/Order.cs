using System.Collections.Generic;

namespace PierreTracker.Models
{
  public class Order
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public string DeliveryDate{get; set;}
    public int Price {get;set;}
    public int Id {get;set;}
    private static int _highestOrderId = 0;
    public Order(string title, string description, string deliveryDate, int price)
    {
      Title = title;
      Description = description;
      DeliveryDate = deliveryDate;
      Price = price;
      Id = ++_highestOrderId;
    }
    public static void ClearAll()
    {
      _highestOrderId = 0;
    }
  }
}

//order
//title?, description, price, date, assign ids. find method