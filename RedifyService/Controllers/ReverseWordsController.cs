using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace RedifyService.Controllers
{
    [Route("api/")]
    public class ReverseWordsController : Controller
    {  

        /// <summary>
        /// Reverses the letters of each word in a sentence.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns>string</returns>
        [HttpGet]
        [Route("ReverseWords")]
        public IActionResult ReverseWords(Input input)
        {
            if(!ModelState.IsValid)
            {
                return Ok("The request is invalid");
            }
            try
            {
                if (string.IsNullOrEmpty(input.sentence)) return Ok(string.Empty);
                return Ok(string.Join(" ", input.sentence.Split(' ').Select(x => new String(x.Reverse().ToArray()))));
            }
            catch
            {
                return Ok("Error");
            }
        }

        public class Input
        {
            public string sentence { set; get; }
        }
    }
}
