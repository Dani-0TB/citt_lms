using Microsoft.AspNetCore.Mvc;

namespace citt_lms.Controllers.Api;

[Route("api/[controller]")]
[ApiController]
public class TallerControler: ControllerBase
{
    [HttpGet]
    public IActionResult Talleres ()

    {
        Object obj = new { Key=1, Name="Dani"};
        return Ok(obj);
    }

    [HttpGet("{id}")]
    public IActionResult Talleres(string id)
    {
        return Ok();
    }
}