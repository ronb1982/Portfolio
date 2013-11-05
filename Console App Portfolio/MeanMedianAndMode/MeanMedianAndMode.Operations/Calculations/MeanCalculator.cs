using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanMedianAndMode.Operations.Calculations
{
    public class MeanCalculator
    {
        public decimal CalculateMean(List<decimal> numbers)
        {
            if (!numbers.Any())
            {
                throw new ArgumentException("No numbers provided!", "numbers");
            }
            
            return numbers.Average();
        }
    }
}
