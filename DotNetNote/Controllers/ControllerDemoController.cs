using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.Controllers
{
    public class ControllerDemoController : Controller
    {
        public void Index()
        {

        }

        public string StringAction()
        {
            return "String 반환";
        }

        public DateTime DateTimeAction()
        {
            return DateTime.Now;
        }

        public IActionResult DefaultAction()
        {
            return View();
        }
    }
}
