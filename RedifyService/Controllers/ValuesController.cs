using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RedifyService.Controllers
{
    [Route("api/")]
    public class ValuesController : Controller
    {
        [HttpGet]
        [Route("Token")]
        public string Token()
        {
            return "8c5965a8-cecb-4032-bd81-4e03438aab1e";
        }

        [HttpGet]
        [Route("Fibonacci/{n}")]
        public long Fibonacci(long n)
        {
            return GetNthFibonacciNumber(n);
        }

        
        [HttpGet]
        [Route("ReverseWords/{sentence?}")]
        public string ReverseWords(string sentence = "")
        {
            return string.Join(" ", sentence.Split(' ').Select(x => new String(x.Reverse().ToArray())));
        }

        [HttpGet]
        [Route("TriangleType/{a}/{b}/{c}")]
        public string TriangleType(int a, int b, int c)
        {
            return GetTriangleType(a, b, c);
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

        private string GetTriangleType(int side1, int side2, int side3)
        {
            try
            {
                //checked if any side of triagle is not zero
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    return "Error";
                }

                //check for triangle inequality theorem

                if (((side2 + side3) < side1) || ((side1 + side3) < side2) || ((side1 + side2) < side3))
                {
                    return "Error";
                }

                //check if all sides are equal
                if (side1 == side2 && side1 == side3)
                {
                    return "Equilateral";
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3) //check if any two sides are equal
                {
                    return "Isosceles";
                }
                else //this block will be executed of none of the sides are equal
                {
                    return "Scalene";
                }
            }
            catch (Exception ex)
            {
                return "Error";
            }
        }
    }
}
