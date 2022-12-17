using Microsoft.AspNetCore.Mvc;
using PierreTracker.Models;
using System.Collections.Generic;

namespace PierreTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.GetVendor(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string title, string description, string date, int price)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.GetVendor(vendorId);
      Order newOrder = new Order(title, description, date, price);
      selectedVendor.AddOrder(newOrder);
      model.Add("vendor", selectedVendor);
      model.Add("orders", selectedVendor.Orders);
      return View("Show", model);
    }
    [HttpPost("/vendors/delete")]
    public ActionResult Delete(int id)
    {
      Vendor.DeleteVendor(id);
      return RedirectToAction("Index");
    }
  }
}