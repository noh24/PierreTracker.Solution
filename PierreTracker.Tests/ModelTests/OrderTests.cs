using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreTracker.Models;
using System;
using System.Collections.Generic;
namespace PierreTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
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
  }
}