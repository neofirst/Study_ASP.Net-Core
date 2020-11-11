using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DotNetNote.Controllers
{
    public class LoggingDemoController : Controller
    {
        private ILogger<LoggingDemoController> _logger;

        public LoggingDemoController(ILogger<LoggingDemoController> logger)
        {
            this._logger = logger;
        }

        public IActionResult Index()
        {
            this._logger.LogInformation("Index View {time}", DateTime.Now);
            return View();
        }

        public IActionResult About()
        {
            this._logger.LogInformation("About View {time}", DateTime.Now);
            return View();
        }
    }
}
