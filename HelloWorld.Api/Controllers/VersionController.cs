using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VersionController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            application = "HelloWorld.Api",
            version = "1.0",
            environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")
                           ?? "Unknown"
        });
    }
}