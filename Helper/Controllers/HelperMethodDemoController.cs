using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Helper.Controllers
{
    public class HelperMethodDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FormDemo()
        {
            return View();
        }

        public IActionResult InputDemo()
        {
            return View();
        }

        public IActionResult SelectDemo()
        {
            return View();
        }

        /// <summary>
        /// 특정 모델 클래스 사용 뷰
        /// </summary>
        /// <returns></returns>
        public IActionResult StronglyTypedDemo()
        {
            var stc = new StrongTypedClass()
            {
                Id = 1,
                Name = "Neo",
                Age = 21
            };
            return View(stc);
        }

        public IActionResult CssClassDemo()
        {
            return View();
        }

        public IActionResult PartialViewDemo()
        {
            return View();
        }
    }

    public class StrongTypedClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
