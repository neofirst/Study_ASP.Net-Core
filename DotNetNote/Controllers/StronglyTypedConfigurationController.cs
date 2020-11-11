using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using DotNetNote.Settings;
using Microsoft.Extensions.Options;

namespace DotNetNote.Controllers
{
    public class StronglyTypedConfigurationController : Controller
    {
        private DotNetNoteSettings _dnnSetting;

        public StronglyTypedConfigurationController(IOptions<DotNetNoteSettings> options)
        {
            this._dnnSetting = options.Value;
        }

        public IActionResult Index()
        {
            ViewData["SiteName"] = this._dnnSetting.SiteName;
            ViewBag.SiteUrl = this._dnnSetting.SiteUrl;
            return View();
        }
    }
}
