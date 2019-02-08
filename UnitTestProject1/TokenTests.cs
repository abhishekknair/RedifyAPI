using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedifyService.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class Token
    {
        [TestMethod]
        public void GetTokenShouldReturnToken()
        {
            var tokenController = new TokenController();
            var token = tokenController.GetToken();
        }
    }
}
