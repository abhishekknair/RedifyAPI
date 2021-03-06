﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ReadifyService.Controllers
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
        public IActionResult ReverseWords(string sentence)
        {
            try
            {
                return string.IsNullOrEmpty(sentence) ? StatusCode(200, string.Empty)
                    : StatusCode(200, (string.Join(" ", sentence.Split(' ').Select(x => new String(x.Reverse().ToArray())))));
            }
            catch
            {
                return StatusCode(200, "Error");
            }
        }
    }
}
