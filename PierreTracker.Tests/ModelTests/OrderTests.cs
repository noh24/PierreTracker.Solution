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
    [TestMethod]
    public void GetAll_ReturnsAllOrders_OrderList()
    {
      Order newOrder = new Order("title", "description", "deliveryDate", 1);
      Order newOrder2 = new Order("title", "description", "deliveryDate", 1);
      List<Order> orderList = new List<Order> { newOrder, newOrder2 };
      CollectionAssert.AreEqual(orderList, Order.GetAll());
    }
    [TestMethod]
    public void FindIndex_ReturnsCorrectIndexOfOrderById_Int()
    {
      Order newOrder = new Order("title", "description", "deliveryDate", 1);
      Order newOrder2 = new Order("title", "description", "deliveryDate", 1);
      Assert.AreEqual(0, Order.FindIndex(1));
      Assert.AreEqual(1, Order.FindIndex(2));
    }
    [TestMethod]
    public void GetOrder_ReturnsCorrectOrder_Order()
    {
      Order newOrder = new Order("title", "description", "deliveryDate", 1);
      Order newOrder2 = new Order("title", "description", "deliveryDate", 1);
      Assert.AreEqual(newOrder, Order.GetOrder(1));
      Assert.AreEqual(newOrder2, Order.GetOrder(2));
    }
    [TestMethod]
    public void DeleteOrder_RemovesCorrectOrderFromList_OrderList()
    {
      Order newOrder = new Order("title", "description", "deliveryDate", 1);
      Order newOrder2 = new Order("title", "description", "deliveryDate", 1);
      List<Order> orderList = new List<Order> { newOrder };
      Order.DeleteOrder(2);
      CollectionAssert.AreEqual(orderList, Order.GetAll());
    }
  }
}