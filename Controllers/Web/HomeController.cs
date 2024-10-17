using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace citt_lms.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet, Route("api/version")]
    public IActionResult Version()
    {
        return Ok("1.1.1");
    }
}
