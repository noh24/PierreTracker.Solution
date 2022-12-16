using System.Collections.Generic;

namespace PierreTracker.Models
{
  public class Order
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public string DeliveryDate{get; set;}
    public int Price {get;set;}
    public Order(string title, string description, string deliveryDate, int price)
    {
      Title = title;
      Description = description;
      DeliveryDate = deliveryDate;
      Price = price;
    }
  }
}

//order
//title?, description, price, date, assign ids. find method