using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadifyService.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadifyService.Tests
{
    [TestClass]
    public class ReverseWordsControllerTests
    {
        [TestMethod]
        public void ShouldReturnCorrectReturnTypeOnReverseWords()
        {
            var controller = new ReverseWordsController();
            var response = controller.ReverseWords("sentence");
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ShouldReturnStatus200ReverseWords()
        {
            var controller = new ReverseWordsController();
            var response = controller.ReverseWords("sentence");
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
        }

        [TestMethod]
        public void ShouldReturnCorrectResponseOnReverseWords()
        {
            var controller = new ReverseWordsController();
            var response = controller.ReverseWords("sentence");
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual("ecnetnes", result.Value);
        }

        [TestMethod]
        public void ShouldReturnCorrectResponseOnReverseWordswithSpaces()
        {
            var controller = new ReverseWordsController();
            var response = controller.ReverseWords("How are you?");
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual("woH era ?uoy", result.Value);
        }

        [TestMethod]
        public void ShouldReturnStringEmptyOnReverseWordsIfPassedNull()
        {
            var controller = new ReverseWordsController();
            var response = controller.ReverseWords(null);
            Assert.IsInstanceOfType(response, typeof(ObjectResult));
            var result = response as ObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual(string.Empty, result.Value);
        }
    }
}
