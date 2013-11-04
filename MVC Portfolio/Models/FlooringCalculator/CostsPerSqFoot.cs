using System.Collections.Generic;

namespace MVCPortfolio.Models.FlooringCalculator
{
    public class CostsPerSqFoot
    {
        public List<Prices> RatesList { get; set; }
        
        public CostsPerSqFoot()
        {
            RatesList = new List<Prices>()
            {
                new Prices() {Id = 1, Rate = 1.00m},
                new Prices() {Id = 2, Rate = 2.00m},
                new Prices() {Id = 3, Rate = 5.00m},
                new Prices() {Id = 4, Rate = 10.00m}
            };
        }

        
    }
}