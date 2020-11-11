using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TagHelperTest.Controllers
{
    public class TagHelperDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EnvironmentDemo()
        {
            return View();
        }

        public IActionResult PrefixDemo()
        {
            return View();
        }

        public IActionResult MyTagHelperDemo()
        {
            return View();
        }

        public IActionResult EmailLinkDemo()
        {
            return View();
        }

        public IActionResult TagHelperDemo()
        {
            return View();
        }

        public IActionResult PagingHelperDemo()
        {
            return View();
        }

        public IActionResult CacheDemo()
        {
            return View();
        }
    }
}
