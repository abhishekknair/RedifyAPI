using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace RedifyService.Controllers
{
    [Route("api/")]
    public class FibonacciController : Controller
    {
        /// <summary>
        /// Returns the nth number in the fibonacci sequence.
        /// </summary>
        /// <param name="req"></param>
        /// <returns>Req</returns>
        [HttpGet]
        [Route("Fibonacci/")]
        public IActionResult Fibonacci(Req req)
        {
            try
            {
                if(!ModelState.IsValid)
                {

                    return StatusCode(400,"The request is invalid");
                }
                var l = Convert.ToInt64(req.n);
                if (l == 0)
                    return Ok(0);
                else
                    return StatusCode(200,GetNthFibonacciNumber(l));
            }
            catch(System.OutOfMemoryException)
            {
                return StatusCode(400,"A value in the fibonacci sequence can only be number");
            }
            catch
            {
                return StatusCode(500,"Error");
            }
        }

        private long GetNthFibonacciNumber(long n)
        {
            long number = n - 1; //Need to decrement by 1 since we are starting from 0
            long[] Fib = new long[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            Double d;

            for (long i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
                if (Double.IsNaN(Convert.ToDouble(Fib[i-2])))
                {
                    throw new Exception("A value in the fibonacci sequence can only be number");
                }
                if (Double.IsNaN(Convert.ToDouble(Fib[i-1])))
                {
                    throw new Exception("A value in the fibonacci sequence can only be number");
                }
                if (Double.IsNaN(Convert.ToDouble(Fib[i])))
                {
                    throw new Exception("A value in the fibonacci sequence can only be number");
                }
            }
            return Fib[number];
        }        
    }

    public class Req
    {
        [Range(0, Int64.MaxValue, ErrorMessage = "The request is invalid")]
        public long? n { set; get; }
    }
}
