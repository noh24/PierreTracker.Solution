using System.Collections.Generic;

namespace PierreTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string DeliveryDate { get; set; }
    public int Price { get; set; }
    public int Id { get; set; }
    private static int _highestOrderId = 0;
    private static List<Order> _instances = new List<Order> { };
    public Order(string title, string description, string deliveryDate, int price)
    {
      Title = title;
      Description = description;
      DeliveryDate = deliveryDate;
      Price = price;
      Id = ++_highestOrderId;
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _highestOrderId = 0;
      _instances.Clear();
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static int FindIndex(int id)
    {
      for (int i = 0; i < _instances.Count; i++)
      {
        if (_instances[i].Id == id)
        {
          return i;
        }
      }
      return -1;
    }
    public static Order GetOrder(int id)
    {
      int foundIndex = FindIndex(id);
      return _instances[foundIndex];
    }
    // public static void DeleteOrder(int id)
    // {
    //   int foundIndex = FindIndex(id);
    //   if (foundIndex != -1)
    //   {
    //     _instances.RemoveAt(foundIndex);
    //   }
    // }
  }
}

//order
//title?, description, price, date, assign ids. find method