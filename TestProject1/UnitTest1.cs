using GithubActions.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TestProject1
{
    public class UnitTest1
    {
        public class HomeControllerTests
        {
            [Fact]
            public void Index_ReturnsViewResult()
            {
                // Arrange
                var controller = new HomeController();

                // Act
                var result = controller.Index();

                // Assert
                Assert.IsType<ViewResult>(result);
            }
        }
    }
}