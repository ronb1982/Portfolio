using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanMedianAndMode.Operations.Calculations
{
    public class MedianCalculator
    {
        public string CalculateMedian(List<decimal> numbers)
        {
            decimal median = 0;

            numbers.Sort();

            bool evenLength = numbers.Count % 2 == 0;

            int middleNumber = numbers.Count / 2;

            if (numbers.Count == 0)
                throw new ArgumentException("No numbers provided!");

            if (evenLength)
                return GetMedianFromTwoMiddleNumbers(numbers, median, middleNumber);

            return GetMedianFromOneNumber(numbers, median, middleNumber);
        }

        
        //======================================================================================================//
        
        private string GetMedianFromOneNumber(List<decimal> numbers, decimal median, int middleNumber)
        {
            median = Math.Floor(numbers[middleNumber]);

            return string.Format("{0}", median);
        }

        private string GetMedianFromTwoMiddleNumbers(List<decimal> numbers, decimal median, int middleNumber)
        {
            decimal sum = 0;

            sum = Math.Floor(numbers[middleNumber - 1]) + (Math.Floor(numbers[middleNumber]));
            median = sum / 2;

            return string.Format("{0}", median);
        }
    }
}
