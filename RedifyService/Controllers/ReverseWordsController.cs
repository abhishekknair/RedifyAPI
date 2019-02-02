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
        [Route("ReverseWords/{sentence?}")]
        public string ReverseWords(string sentence = "")
        {
            return string.Join(" ", sentence.Split(' ').Select(x => new String(x.Reverse().ToArray())));
        }        
    }
}
