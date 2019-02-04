using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace RedifyService.Controllers
{

    [Route("api/")]
    public class TriangleTypeController : Controller
    {
        /// <summary>
        /// Returns the type of triange given the lengths of its sides
        /// </summary>  
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>string</returns>
        [HttpGet]
        [Route("TriangleType")]
        public IActionResult TriangleType(Request request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("The request is invalid");
            }
            try
            {
                var response = GetTriangleType(request.a, request.b, request.c);

                return Ok(response);
            }
            catch
            {
                return Ok("Error");
            }
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

    public class Request
    {
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "The request is invalid")]
        public int a { set; get; }

        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "The request is invalid")]
        public int b { set; get; }

        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "The request is invalid")]
        public int c { set; get; }
    }
}
