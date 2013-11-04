using System.ComponentModel.DataAnnotations;

namespace MVCPortfolio.Models.FlooringCalculator
{
    public class Prices
    {
        
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter a rate (in decimal form).")]
        public decimal Rate { get; set; }
    }
}