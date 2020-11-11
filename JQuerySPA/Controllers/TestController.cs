using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API_DB.Models;
using System.Net.Http;
using System.Net;

namespace JQuerySPA.Controllers
{
    [Produces("application/json")]
    [Route("api/Test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private ITechRepository _repo;

        public TestController(ITechRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("Search")]
        public ActionResult Search()
        {
            return Ok(_repo.GetTechs());
        }

        [HttpPost("SetData")]
        public HttpResponseMessage SetData([FromBody] Tech tech)
        {
            _repo.AddTech(tech);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            return response;
        }

        [HttpPut("UpdateData")]
        public HttpResponseMessage UpdateData([FromBody] Tech tech)
        {
            _repo.UpdateData(tech);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            return response;
        }

        [HttpDelete("DeleteData")]
        public HttpResponseMessage DeleteData([FromBody] Tech tech)
        {
            _repo.DeleteData(tech);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            return response;
        }
    }
}
