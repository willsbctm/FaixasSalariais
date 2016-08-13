using FaixasSalariais.Controllers;
using System.Web.Mvc;
using Xunit;

namespace FaixasSalariais.Tests.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

  
            // Assert
            Assert.NotNull(result);
        }
    }
}
