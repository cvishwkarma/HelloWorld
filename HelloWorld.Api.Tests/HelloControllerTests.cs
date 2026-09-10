using HelloWorld.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Api.Tests;

public class HelloControllerTests
{
    [Fact]
    public void Get_ShouldReturnSuccess()
    {
        // Arrange
        var controller = new HelloController();

        // Act
        var result = controller.Get();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);

        Assert.NotNull(okResult.Value);
    }
}