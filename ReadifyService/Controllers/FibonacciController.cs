using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReadifyService.Controllers
{
    [Route("api/[controller]")]
    public class FibonacciController : Controller
    {
        private double phi = 1.6180339;
        private int[] f = { 0, 1, 1, 2, 3, 5 };

        /// <summary>
        /// Returns the nth number in the fibonacci sequence.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>n</returns>
        [HttpGet]
        [Route("Fibonacci")]
        public IActionResult Fibonacci(long n)
        {
            try
            {
                if (Double.IsNaN(Convert.ToDouble(n)))
                {
                    return StatusCode(200, "Error");
                }
                return n == 0 ? StatusCode(200, 0)
                    : StatusCode(200, GetNthFibonacciNumber(n));
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith(""))
                    return StatusCode(400, "no content");
                else
                    return StatusCode(200, "Error");
            }
        }

        private long GetNthFibonacciNumber(long n)
        {
            if (n < 6)
                return f[n];

            long t = 5;
            long fn = 5;

            while (t < n)
            {
                fn = (long)Math.Round(fn * phi);
                t++;
            }

            if (Double.IsNaN(Convert.ToDouble(fn)) || fn < 0)
            {
                throw new Exception("A value in the fibonacci sequence can only be number");
            }

            return fn;
        }
    }
}
