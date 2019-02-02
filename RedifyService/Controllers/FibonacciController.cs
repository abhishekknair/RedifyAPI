using Microsoft.AspNetCore.Mvc;
using System;

namespace RedifyService.Controllers
{
    [Route("api/")]
    public class FibonacciController : Controller
    {
        /// <summary>
        /// Returns the nth number in the fibonacci sequence.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>long</returns>
        [HttpGet]
        [Route("Fibonacci/{n}")]
        public long Fibonacci(long n)
        {
            return GetNthFibonacciNumber(n);
        }

        private long GetNthFibonacciNumber(long n)
        {
            Console.WriteLine("nth fib number");
            long number = n - 1; //Need to decrement by 1 since we are starting from 0
            long[] Fib = new long[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;

            for (long i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[number];
        }        
    }
}
