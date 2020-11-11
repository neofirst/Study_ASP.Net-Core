using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularSPA.Controllers
{
    public class WebCampController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
