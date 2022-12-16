using System.Collections.Generic;


namespace PierreTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }
    private static int _highestVendorId = 0;
    private static List<Vendor> _instances = new List<Vendor> { };

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Id = ++_highestVendorId;
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
      _highestVendorId = 0;
    }
    public static List<Vendor> GetAll()
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
    public static Vendor GetVendor(int id)
    {
      int foundIndex = FindIndex(id);
      return _instances[foundIndex];
    }
  }
}
//vendor (people who bought)
// name, description, list of orders, static list vendors, assign ids, find method paid or not

//order
//title?, description, price, date, assign ids. find method