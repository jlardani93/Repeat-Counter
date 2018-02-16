using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RepeatCounterProject.Models;

namespace RepeatCounterProject.Controllers
{
  public class RepeatCounterController : Controller
  {
    [HttpGet("RepeatCounter/Form")]
    public ActionResult Form()
    {
      return View();
    }

    [HttpPost("RepeatCounter/Display")]
    public ActionResult Display()
    {
      RepeatCounter.SetUserWord(Request.Form["userWord"]);
      RepeatCounter.SetUserSentence(Request.Form["userSentence"]);
      return RedirectToAction("Index", "Home");
    }
  }
}
