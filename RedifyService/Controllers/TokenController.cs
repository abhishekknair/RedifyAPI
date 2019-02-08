using Microsoft.AspNetCore.Mvc;

namespace RedifyService.Controllers
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
            return StatusCode(200,"8c5965a8-cecb-4032-bd81-4e03438aab1e");
        }
    }
}
