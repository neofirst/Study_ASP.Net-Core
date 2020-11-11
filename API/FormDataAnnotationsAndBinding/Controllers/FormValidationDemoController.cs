using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormDataAnnotationsAndBinding.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormDataAnnotationsAndBinding.Controllers
{
    public class FormValidationDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Html()
        {
            return View();
        }

        public IActionResult HtmlProcess(string txtName, string txtContent)
        {
            ViewBag.ResultString = $"이름:{txtName}, 내용:{Request.Form["txtContent"]}";
            return View();
        }

        [HttpGet]
        public IActionResult HelperMethod()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HelperMethod(string txtName, string txtContent)
        {
            ViewBag.ResultString = $"이름:{txtName}, 내용:{txtContent}";
            return View();
        }

        [HttpGet]
        public IActionResult StronglyTypeView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StronglyTypeView(MaximModel model)
        {
            return View();
        }

        [HttpGet]
        public IActionResult ModelValidation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ModelValidation(MaximModel model)
        {
            if (string.IsNullOrEmpty(model.Name))
            {
                ModelState.AddModelError("Name", "이름을 입력하시오.");
            }
            if (string.IsNullOrEmpty(model.Content))
            {
                ModelState.AddModelError("Content", "내용을 입력하시오.");
            }

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "모든 에러");
            }

            if (ModelState.IsValid)
            {
                return View("Completed");
            }

            return View();
        }

        public IActionResult Completed()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ClientValidation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TagHelperValidation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TagHelperValidation(MaximModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Completed");
            }
            return View();
        }
        [HttpPost]
        public IActionResult ClientValidation(MaximModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Completed");
            }
            return View();
        }
    }
}
