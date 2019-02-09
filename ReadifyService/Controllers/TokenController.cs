using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReadifyService.Controllers
{
    [Route("api/")]
    public class TokenController : Controller
    {
        /// <summary>
        /// Your token.
        /// </summary>
        /// <returns>string</returns>
        [HttpGet]
        [Route("Token")]
        public IActionResult GetToken()
        {
            return StatusCode(200, "8c5965a8-cecb-4032-bd81-4e03438aab1e");
        }
    }
}
