using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReadifyService.Controllers
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
        public IActionResult TriangleType(int a, int b, int c)
        {
            try
            {
                var response = GetTriangleType(a, b, c);

                return StatusCode(200, response);
            }
            catch
            {
                return StatusCode(500, "Error");
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
                //check if any two sides are equal
                else if (side1 == side2 || side1 == side3 || side2 == side3) //check if any two sides are equal
                {
                    return "Isosceles";
                }
                else //this block will be executed of none of the sides are equal
                {
                    return "Scalene";
                }
            }
            catch
            {
                return "Error";
            }
        }
    }
}
