using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class DependencyInjectionDemoController : Controller
    {
        private ICopyrightService _service;
        private ICopyrightService _service2;

        //public DependencyInjectionDemoController(ICopyrightService service)
        //{
        //    this._service = service;
        //}

        public DependencyInjectionDemoController(ICopyrightService service, ICopyrightService service2)
        {
            this._service = service;
            this._service2 = service2;
        }

        public IActionResult Index()
        {
            //ViewBag.Copyright = this._service.GetCopyrightString();
            ViewBag.Copyright = this._service.GetCopyrightString() +", " + this._service2.GetCopyrightString();
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Copyright = this._service.GetCopyrightString();
            return View();
        }

        public IActionResult AtInjectionDemo()
        {
            return View();
        }
    }
}
