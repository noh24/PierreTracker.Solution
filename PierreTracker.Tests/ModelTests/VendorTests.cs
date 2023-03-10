using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreTracker.Models;
using System;
using System.Collections.Generic;

namespace PierreTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_ReturnsNameAndDescription_VendorProperties()
    {
      string name = "Cafe1";
      string description = "Cafe";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(name, newVendor.Name);
      Assert.AreEqual(description, newVendor.Description);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      Vendor newVendor = new Vendor("name", "description");
      Vendor newVendor2 = new Vendor("name", "description");
      Assert.AreEqual(1, newVendor.Id);
      Assert.AreEqual(2, newVendor2.Id);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      Vendor newVendor = new Vendor("name", "description");
      List<Vendor> expected = new List<Vendor> { newVendor };
      CollectionAssert.AreEqual(expected, Vendor.GetAll());
    }
    [TestMethod]
    public void FindIndex_ReturnsCorrectIndex_Vendor()
    {
      Vendor newVendor = new Vendor("name", "description");
      Vendor newVendor2 = new Vendor("name", "description");
      Assert.AreEqual(1, Vendor.FindIndex(2));
    }
    [TestMethod]
    public void GetVendor_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor = new Vendor("name", "description");
      Vendor newVendor2 = new Vendor("name", "description");
      Assert.AreEqual(newVendor, Vendor.GetVendor(1));
      Assert.AreEqual(newVendor2, Vendor.GetVendor(2));
    }
    [TestMethod]
    public void DeleteVendor_RemovesVendorFromList_VendorList()
    {
      Vendor newVendor = new Vendor("name", "description");
      Vendor newVendor2 = new Vendor("name", "description");
      List<Vendor> VendorList = new List<Vendor> { newVendor };
      Vendor.DeleteVendor(2);
      CollectionAssert.AreEqual(VendorList, Vendor.GetAll());
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      Vendor newVendor = new Vendor("name", "description");
      Order newOrder = new Order("title", "description", "deliveryDate", 1);
      newVendor.AddOrder(newOrder);
      List<Order> orderList = new List<Order> {newOrder};
      CollectionAssert.AreEqual(orderList, newVendor.Orders);
    }
  }
}
