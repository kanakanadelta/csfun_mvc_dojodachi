using Microsoft.AspNetCore.Mvc;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}