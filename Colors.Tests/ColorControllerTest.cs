using ColorsMedium.WebApi.Controllers;
using ColorsMedium.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Colors.Tests
{
    public class ColorControllerTest
    {
        private ColorController _controller;
        public ColorControllerTest()
        {
            _controller = new ColorController();
        }

        [Fact]
        public void GetAllColorsTest()
        {
            var response = _controller.GetAllColors() as OkObjectResult; 
            var colors = response.Value as List<Color>; 

            Assert.NotNull(colors);
        }

        [Theory]
        [InlineData("Red")]
        [InlineData("Black")]
        public void GetColorTest(string color)
        {
            var response = _controller.GetByName(color) as OkObjectResult;
            var returnColor = response.Value as Color; 

            //Assert.NotNull(returnColor);
            Assert.Equal(color.ToUpper(), returnColor.Name.ToUpper());
        }
    }
}
