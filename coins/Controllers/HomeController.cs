using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Coins.Models;

namespace Coins.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/coins/results")]
    public ActionResult Results()
    {
      Coiner newCoin = new Coiner (int.Parse(Request.Form["inputNumber"]));
      List<string> result = newCoin.GetValue(newCoin.GetNumber());
      return View (result);
    }
  }
}
