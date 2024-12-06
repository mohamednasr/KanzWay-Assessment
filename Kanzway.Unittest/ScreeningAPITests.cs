using Kanzway.API.Controllers;
using Kanzway.API.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Kensway.Unittest
{
    public class ScreeningAPITests
    {
        [Fact]
        public void Index_ShouldReturnsBadRequest()
        {
            var controller = new ScreeningController();

            var exception = Assert.Throws<BusinessRuleException>(() => controller.Index(0));
            Assert.Equal("Input should be Greater than or Equal to 1", exception.Message);
        }

        [Fact]
        public void Index_ShouldReturnsListWithOneItem()
        {
            var controller = new ScreeningController();
            var result = controller.Index(1);

            var responseList = Assert.IsType<OkObjectResult>(result);
            Assert.Equal((int)HttpStatusCode.OK, responseList.StatusCode.Value);
            Assert.Equal(new List<string> { "1" }, responseList.Value);
        }

        [Fact]
        public void Index_ShouldReturnsListWithFiveItems()
        {
            var controller = new ScreeningController();
            var result = controller.Index(5);

            var responseList = Assert.IsType<OkObjectResult>(result);
            Assert.Equal((int)HttpStatusCode.OK, responseList.StatusCode.Value);
            Assert.Equal(new List<string> { "1", "2", "Kanz", "4", "Way" }, responseList.Value);
        }

        [Fact]
        public void Index_ShouldReturnsListWithCorrectList()
        {
            var controller = new ScreeningController();
            var result = controller.Index(15);

            var responseList = Assert.IsType<OkObjectResult>(result);
            Assert.Equal((int)HttpStatusCode.OK, responseList.StatusCode.Value);
            Assert.Equal(new List<string> { "1", "2", "Kanz", "4", "Way", "Kanz", "7", "8", "Kanz", "Way", "11", "Kanz", "13", "14", "KanzWay" }, responseList.Value);
        }
    }
}