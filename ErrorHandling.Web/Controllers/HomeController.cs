using ErrorHandling.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ErrorHandling.Web.Controllers;

public class HomeController : Controller
{
    SlowService service = new SlowService();

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

    [HttpGet("slow")]
    public async Task<IActionResult> Slow()
    {
        await service.DoSlowWork();
        return Content("Work done!");
    }
}
