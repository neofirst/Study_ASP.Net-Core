using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace Authentication.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class WebApiTestWithAuthorizeController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "[Authorize]특성을 적용하려면,", "인증되지 않았을 때 로그인 페이지로 이동합니다." };
        }
    }
}
