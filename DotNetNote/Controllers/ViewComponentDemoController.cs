﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.Controllers
{
    public class ViewComponentDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CopyrightDemo()
        {
            return View();
        }

        public IActionResult TechListDemo()
        {
            return View();
        }

        public IActionResult SiteListDemo()
        {
            return View();
        }
    }
}
