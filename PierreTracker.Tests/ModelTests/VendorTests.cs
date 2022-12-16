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
    public void FindIndex_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor = new Vendor("name", "description");
      Vendor newVendor2 = new Vendor("name", "description");
      Assert.AreEqual(1 , Vendor.FindIndex(2));
    }
  }
}
