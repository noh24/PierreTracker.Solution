using System;
using System.Collections.Generic;


namespace PierreTracker.Models
{
  public class Vendor
  {
    public string Name {get; set;}
    public string Description {get; set;}
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
    }
  }
}
//vendor (people who bought)
// name, description, list of orders, static list vendors, assign ids, find method paid or not

//order
//title?, description, price, date, assign ids. find method