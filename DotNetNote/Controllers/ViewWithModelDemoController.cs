using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetNote.Models;

namespace DotNetNote.Controllers
{
    public class ViewWithModelDemoController : Controller
    {
        public IActionResult Index()
        {
            DemoModel dm = new DemoModel();
            dm.Id = 1;
            dm.Name = "Neo Test";
            return View(dm);
        }
    }
}
