using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreTracker.Models;
using System;
using System.Collections.Generic;
namespace PierreTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_ReturnsValidProperties_OrderProperties()
    {
      string title = "title for order";
      string description = "order for bakery";
      string deliveryDate = "yyyy-mm-dd";
      int price = 1;
      Order newOrder = new Order(title, description, deliveryDate, price);
      Assert.AreEqual(title, newOrder.Title);
      Assert.AreEqual(description, newOrder.Description);
      Assert.AreEqual(deliveryDate, newOrder.DeliveryDate);
      Assert.AreEqual(price, newOrder.Price);
    }
    [TestMethod]
    public void GetId_ReturnsCorrectOrderId_Int()
    {
      Order newOrder = new Order("title", "description", "deliveryDate", 1);
      Order newOrder2 = new Order("title", "description", "deliveryDate", 1);
      Assert.AreEqual(1, newOrder.Id);
      Assert.AreEqual(2, newOrder2.Id);
    }
  }
}