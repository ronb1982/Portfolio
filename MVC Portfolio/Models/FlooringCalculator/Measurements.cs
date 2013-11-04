using System.ComponentModel.DataAnnotations;

namespace MVCPortfolio.Models.FlooringCalculator
{
    public class Measurements
    {
        [Required(ErrorMessage = "Please enter length.")]
        public decimal Length { get; set; }

        [Required(ErrorMessage = "Please enter width.")]
        public decimal Width { get; set; }

        public decimal Area { get; set; }
        
    }
}