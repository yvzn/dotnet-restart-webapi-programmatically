using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApplicationLifetimeStopApplication.Controllers;

[ApiController]
[Route("[controller]")]
public class AdminController(IHostApplicationLifetime appLifetime) : ControllerBase
{
    private IHostApplicationLifetime ApplicationLifetime { get; set; } = appLifetime;

    [HttpGet]
    [Route("shutdown-r")]
    public IActionResult ShutdownSite()
    {
        // reboot: launch the current .exe but with delay at the beginning of Main()
        var pathToApplication = Process.GetCurrentProcess().MainModule?.FileName;
        if (pathToApplication is not null)
        {
            Process.Start(pathToApplication, "--delay");
        }

        // shutdown the current .exe
        ApplicationLifetime.StopApplication();

        return Ok("Done");
    }
}
