using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ApiHelloWorld.Controllers
{
    [Route("api/[controller]")]
    public class WebApiDemoController : Controller
    {
        [HttpGet]
        public JsonResult Get()
        {
            return Json(new { Name = "Neo" });
        }

        [HttpPost]
        public JsonResult Post([FromBody] WebApiDemoClass name)
        {
            if (ModelState.IsValid)
            {
                Response.StatusCode = (int)HttpStatusCode.Created;
                return Json(true);
            }
            Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return Json("실패");
        }
    }


    public class WebApiDemoClass
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "3자이상")]
        public string Name { get; set; }
    }
}
