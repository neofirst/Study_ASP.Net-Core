using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API_DB.Models;
using System.Net.Http;
using System.Net;

namespace API_DB.Controllers
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
        public void SetData([FromBody] Tech tech)
        {
            //if (ModelState.IsValid)
            //{
            //    // 데이터 입력
            //    _repo.AddTech(tech);

            //    //HttpResponseMessage response =
            //    //    Request.CreateResponse(HttpStatusCode.Created, tech);

            //    return new HttpResponseMessage(HttpStatusCode.Created);
            //    //response.Headers.Location =
            //    //    new Uri(Url.Link("DefaultApi", new { id = tech.Title }));
            //    //return response;
            //}
            //else
            //{
            //    //return Request.CreateErrorResponse(
            //    //    HttpStatusCode.BadRequest, ModelState);
            //    return new HttpResponseMessage(HttpStatusCode.BadRequest);
            //}
            // 데이터 입력
            _repo.AddTech(tech);
        }
        //[HttpPost]
        //public HttpResponseMessage Post([FromBody] Tech tech)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // 데이터 입력
        //        _repo.AddTech(tech);

        //        HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Created, tech);
        //            //Request.CreateResponse(HttpStatusCode.Created, tech);
        //        response.Headers.Location =
        //            new Uri(Url.Link("DefaultApi", new { id = tech.Id }));
        //        return response;
        //    }
        //    else
        //    {
        //        return Request.CreateErrorResponse(
        //            HttpStatusCode.BadRequest, ModelState);
        //    }
        //}
    }
}
