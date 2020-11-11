using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.Controllers
{
    public class ViewBagDemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Neo";
            ViewBag.Age = 21;
            ViewBag.Want = "Want";
            ViewData["ViewData"] = "ViewData";

            return View();
        }
    }
}
