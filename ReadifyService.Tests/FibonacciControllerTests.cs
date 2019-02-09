using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadifyService.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadifyService.Tests
{
    [TestClass]
    public class FibonacciControllerTests
    {
        [TestMethod]
        public void ShouldReturnCorrectReturnTypeOnFibonacci()
        {
            var controller = new FibonacciController();
            var response = controller.Fibonacci(0);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ShouldReturnStatus200OnFibonacci()
        {
            var controller = new FibonacciController();
            var response = controller.Fibonacci(0);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
        }

        [TestMethod]
        public void ShouldReturnZeroOnFibonacciIfInputIsZero()
        {
            var controller = new FibonacciController();
            var response = controller.Fibonacci(0);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual(0, result.Value);
        }

        [TestMethod]
        public void ShouldReturnCorrectResultOnFibonacci()
        {

            var controller = new FibonacciController();
            var response = controller.Fibonacci(50);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual(12586257403, result.Value);

        }

        [TestMethod]
        public void ShouldReturnNoContentResultOnFibonacci()
        {

            var controller = new FibonacciController();
            var response = controller.Fibonacci(1000);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(400, result.StatusCode);
            Assert.AreEqual("no content", result.Value);

        }
    }
}
