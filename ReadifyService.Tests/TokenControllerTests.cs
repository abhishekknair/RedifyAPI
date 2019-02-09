using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadifyService.Controllers;

namespace ReadifyService.Tests
{
    [TestClass]
    public class TokenControllerTests
    {
        [TestMethod]
        public void ShouldReturnCorrectReturnTypeOnGet()
        {
            var controller = new TokenController();
            var response = controller.GetToken();
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ShouldReturnStatus200Get()
        {
            var controller = new TokenController();
            var response = controller.GetToken();
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
        }

        [TestMethod]
        public void ShouldReturnTokenOnGet()
        {
            var controller = new TokenController();
            var response = controller.GetToken();
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual("8c5965a8-cecb-4032-bd81-4e03438aab1e", result.Value);
        }

    }
}
