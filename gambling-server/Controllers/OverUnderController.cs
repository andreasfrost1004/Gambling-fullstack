using Microsoft.AspNetCore.Mvc;
using GamblingServer.Models;
using GamblingServer.Services;

namespace GamblingServer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OverUnderController : ControllerBase
{
    private readonly OverUnderService _service;

    public OverUnderController(OverUnderService service)
    {
        _service = service;
    }

    [HttpPost("play")]
    public ActionResult<OverUnderResult> Play([FromBody] OverUnderRequest request)
    {
        var result = _service.PlayRound(request);
        return Ok(result);
    }
}
