using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Web.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("throw")]
    public IActionResult Throw()
    {
        throw new Exception("test");
        return View();
    }
}
