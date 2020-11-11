using Microsoft.AspNetCore.Mvc;

namespace API_DB.Controllers
{
    public class TechController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
