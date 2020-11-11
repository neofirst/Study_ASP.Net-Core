using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.Controllers
{
    public class CollectionDemoController : Controller
    {
        public IActionResult Index()
        {
            List<DemoModel> models = new List<DemoModel>()
            {
                new DemoModel{Id=1, Name="Neo1"},
                new DemoModel{Id=2, Name="Neo2"},
                new DemoModel{Id=3, Name="Neo3"}
            };

            return View(models);
        }
    }
}
