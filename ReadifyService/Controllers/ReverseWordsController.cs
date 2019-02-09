using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ReadifyService.Controllers
{
    public class ReverseWordsController : Controller
    {
        /// <summary>
        /// Reverses the letters of each word in a sentence.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns>string</returns>
        [HttpGet]
        [Route("ReverseWords")]
        public IActionResult ReverseWords(string sentence)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(200, "The request is invalid");
            }
            try
            {
                return string.IsNullOrEmpty(sentence) ? StatusCode(200, string.Empty)
                    : StatusCode(200, (string.Join(" ", sentence.Split(' ').Select(x => new String(x.Reverse().ToArray())))));
            }
            catch
            {
                return StatusCode(500, "Error");
            }
        }
    }
}
