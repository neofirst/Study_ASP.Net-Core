using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Services;

namespace DependencyInjection.Controllers
{
    public class SingletonDemoController : Controller
    {
        private readonly InfoService _svc;
        public SingletonDemoController(InfoService svc)
        {
            this._svc = svc;
        }

        public IActionResult ConstructorInjectionDemo()
        {
            ViewData["Url"] = this._svc.GetUrl();
            return View("Index");
        }

        public IActionResult Index()
        {
            ViewData["Url"] = "www.github.co.kr";
            return View();
        }

        public IActionResult InfoServiceDemo()
        {
            InfoService svc = new InfoService();
            ViewData["Url"] = svc.GetUrl();
            return View("Index");
        }
    }
}
