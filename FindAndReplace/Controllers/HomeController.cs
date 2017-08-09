using Microsoft.AspNetCore.Mvc;
using FindAndReplace.Models;
using System.Collections.Generic;
using System;
namespace FindAndReplace.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/findreplace")]
    public ActionResult FindReplace()
    {
      string word = Request.Form["word"];
      string replacement = Request.Form["replacement"];
      string sentence = Request.Form["sentence"];
      FindAndReplaceClass fr = new FindAndReplaceClass(word,replacement,sentence);
      return View("Index", fr);
    }
  }
}
