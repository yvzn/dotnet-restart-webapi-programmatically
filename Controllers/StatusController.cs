using ApplicationLifetimeStopApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationLifetimeStopApplication.Controllers;

[ApiController]
[Route("[controller]")]
public class StatusController(ApplicationUptimeService applicationUptimeService) : ControllerBase
{
    [HttpGet]
    public IActionResult GetStatus()
    {
        return Ok($"Server uptime {applicationUptimeService.GetUptime()}");
    }
}
