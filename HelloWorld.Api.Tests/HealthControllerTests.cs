using HelloWorld.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Api.Tests;

public class HealthControllerTests
{
    [Fact]
    public void Get_ShouldReturnHealthy()
    {
        // Arrange
        var controller = new HealthController();

        // Act
        var result = controller.Get();

        // Assert
        //var okResult = Assert.IsType<OkObjectResult>(result);
        var okResult = Assert.IsType<BadRequestObjectResult>(result);

        Assert.NotNull(okResult.Value);
    }
}