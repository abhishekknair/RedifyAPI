using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Net;

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
                return StatusCode(400,"The request is invalid");
            }
            try
            {
                if (string.IsNullOrEmpty(input.sentence)) return Ok(string.Empty);
                return StatusCode(200,(string.Join(" ", input.sentence.Split(' ').Select(x => new String(x.Reverse().ToArray())))));
            }
            catch
            {
                return StatusCode(500,"Error"); 
            }
        }

        public class Input
        {
            public string sentence { set; get; }
        }
    }
}
