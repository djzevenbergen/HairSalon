using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;


namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View("Index", model);
    }

    public ActionResult Create()
    {
      return View("Create");
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      thisStylist.Clients = _db.Clients.Where(client => client.StylistId == id).ToList();
      return View("Details", thisStylist);
    }

    public ActionResult Edit(int id)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View("Edit", thisStylist);
    }

    [HttpPost]
    public ActionResult Edit(Stylist stylist)
    {
      _db.Entry(stylist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      _db.Stylists.Remove(thisStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }


    // [HttpGet("/search")]

    // public ActionResult Search(string search, string searchParam)
    // {
    //   var model;
    //   string route = "";

    //   if (!string.IsNullOrEmpty(search))
    //   {
    //     if (searchParam == "Stylist")
    //     {
    //       model = from m in _db.Stylists select m;
    //       model = model.Where(m => m.FirstName.Contains(search));
    //       List<Stylist> matches = model.ToList();
    //       route = "Stylists";
    //     }
    //     else if (searchParam == "Client")
    //     {
    //       model = from m in _db.Clients select m;
    //       model = model.Where(m => m.FirstName.Contains(search));
    //       List<Stylist> matches = model.ToList();
    //       route = "Clients";
    //     }
    //   }
    //   return RedirectToAction("Search", route, matches);
    // }
  }
}