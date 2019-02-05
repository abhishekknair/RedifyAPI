using Microsoft.AspNetCore.Mvc;
using RedifyService.Models;
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
        public IActionResult ReverseWords(ReverseWordsBindingModel model)
        {
            if(!ModelState.IsValid)
            {
                return StatusCode(200,"The request is invalid");
            }
            try
            {
                if (string.IsNullOrEmpty(model.sentence)) return Ok(string.Empty);
                return StatusCode(200,(string.Join(" ", model.sentence.Split(' ').Select(x => new String(x.Reverse().ToArray())))));
            }
            catch
            {
                return StatusCode(500,"Error"); 
            }
        }
    }
}
