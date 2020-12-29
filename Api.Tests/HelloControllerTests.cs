using Microsoft.AspNetCore.Mvc;
using Api.Controllers;
using Xunit;
using System.Threading.Tasks;

namespace Api.Tests
{
    public class HelloControllerTests
    {
        [Fact]
        public void CanSayHello()
        {
            var controller = new HelloController();
            var result = controller.Hello();
            Assert.Equal("Hello, world!", result);
        }
    }
}
