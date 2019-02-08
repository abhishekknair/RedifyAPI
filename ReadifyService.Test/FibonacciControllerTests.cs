using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedifyService.Controllers;
using RedifyService.Models;
using System;

namespace ReadifyService.Test
{
    [TestClass]
    public class FibonacciControllerTests
    {
        [TestMethod]
        public void ShouldReturnCorrectReturnTypeOnFibonacci()
        {
            var controller = new FibonacciController();
            var model = new FibonacciModelBinder {n=0};
            var response = controller.Fibonacci(model);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ShouldReturnStatus200OnFibonacci()
        {
            var controller = new FibonacciController();
            var model = new FibonacciModelBinder { n = 0 };
            var response = controller.Fibonacci(model);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
        }

        [TestMethod]
        public void ShouldReturnZeroOnFibonacciIfInputIsZero()
        {
            var controller = new FibonacciController();
            var model = new FibonacciModelBinder { n = 0 };
            var response = controller.Fibonacci(model);
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
            var model = new FibonacciModelBinder { n = 1000 };
            var response = controller.Fibonacci(model);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual(8261794739546030242, result.Value);
        }

        [TestMethod]
        public void ShouldReturnStatus200OnFibonacciForOverflowException()
        {
            var controller = new FibonacciController();
            var model = new FibonacciModelBinder { n = 2147483648 };
            var response = controller.Fibonacci(model);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(500, result.StatusCode);
        }

        [TestMethod]
        public void ShouldReturnProperErrorMesssageOnFibonacciForOverflowException()
        {
            var controller = new FibonacciController();
            var model = new FibonacciModelBinder { n = 2147483648 };
            var response = controller.Fibonacci(model);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(500, result.StatusCode);
            Assert.AreEqual("The request is invalid", result.Value);
        }       
    }
}
