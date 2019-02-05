using System;
using System.ComponentModel.DataAnnotations;

namespace RedifyService.Models
{
    public class FibonacciModelBinder
    {
        [Required]
        [Range(0, Int64.MaxValue, ErrorMessage = "The request is invalid")]
        public long n { set; get; }
    }
}
