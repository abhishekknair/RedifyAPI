using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadifyService.Controllers;

namespace ReadifyService.Tests
{
    [TestClass]
    public class TriangleTypeControllerTests
    {
        [TestMethod]
        public void ShouldReturnCorrectReturnTypeOnTriangleType()
        {
            var controller = new TriangleTypeController();
            var response = controller.TriangleType(1, 2, 3);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ShouldReturnStatus200OnTriangleType()
        {
            var controller = new TriangleTypeController();
            var response = controller.TriangleType(1, 2, 3);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
        }

        [TestMethod]
        public void ShouldReturnScaleneOnTriangleType()
        {
            var controller = new TriangleTypeController();
            var response = controller.TriangleType(1, 2, 3);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual("Scalene", result.Value);
        }

        [TestMethod]
        public void ShouldReturnIsoscelesOnTriangleType()
        {
            var controller = new TriangleTypeController();
            var response = controller.TriangleType(2, 2, 3);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual("Isosceles", result.Value);
        }

        [TestMethod]
        public void ShouldReturnEquilateralOnTriangleType()
        {
            var controller = new TriangleTypeController();
            var response = controller.TriangleType(2, 2, 2);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual("Equilateral", result.Value);
        }

        [TestMethod]
        public void ShouldReturnErrorOnTriangleTypeIfRequestIsAll0()
        {
            var controller = new TriangleTypeController();
            var response = controller.TriangleType(0, 0, 0);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual("Error", result.Value);
        }

        [TestMethod]
        public void ShouldReturnErrorOnTriangleTypeIfinequality()
        {
            var controller = new TriangleTypeController();
            var response = controller.TriangleType(100, 10, 1);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual("Error", result.Value);
        }
    }
}
