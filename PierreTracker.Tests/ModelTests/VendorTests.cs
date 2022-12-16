using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreTracker.Models;
using System;
using System.Collections.Generic;

namespace PierreTracker.Tests
{
  [TestClass]
  public class VendorTests 
  {
    [TestMethod]
    public void VendorConstructor_ValidProperties_VendorProperties()
    {
      string name = "Cafe1";
      string description = "Cafe";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(name, newVendor.Name);
      Assert.AreEqual(description, newVendor.Description);
    }
  }
}
