using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Web.Controllers
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
