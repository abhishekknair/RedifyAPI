﻿using Microsoft.AspNetCore.Mvc;
using RedifyService.Models;
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
        [Route("Fibonacci")]
        public IActionResult Fibonacci(FibonacciModelBinder model)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return StatusCode(200,"The request is invalid");
                }
                if (Double.IsNaN(Convert.ToDouble(model.n)))
                {
                    return StatusCode(200, "A value in the fibonacci sequence can only be number");
                }
                if (model.n == 0)
                    return StatusCode(200,0);
                else
                    return StatusCode(200,GetNthFibonacciNumber(model.n));
            }
            catch(OutOfMemoryException)
            {
                return StatusCode(500, "The request is invalid");
            }
            catch (OverflowException)
            {
                return StatusCode(500, "The request is invalid");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error");
            }
        }

        private long GetNthFibonacciNumber(long n)
        {
            long number = n - 1;
            long[] Fib = new long[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;

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
}
