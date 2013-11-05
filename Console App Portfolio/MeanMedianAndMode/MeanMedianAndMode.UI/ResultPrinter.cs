using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeanMedianAndMode.Operations.Calculations;

namespace MeanMedianAndMode.UI
{
    public class ResultPrinter
    {
        public void PrintResults(List<decimal> numbers)
        {
            PrintNumbers(numbers);
            PrintMean(numbers);
            PrintMedian(numbers);
            PrintMode(numbers);


            Console.WriteLine();


            //Console.WriteLine("Median: {0}", median);
            // Console.WriteLine("Mode: {0}", mode);


            //var medianCalc = new MedianCalculator();
            //var median = medianCalc.CalculateMedian(numbers);
        }

        private void PrintNumbers(List<decimal> numbers)
        {
            Console.Write("Entire list of numbers (unsorted): ");
           
            foreach (var d in numbers)
            {
                Console.Write("{0} ", d);
            }

            Console.WriteLine("\n");
        }

        private void PrintMean(List<decimal> numbers)
        {
            try
            {
                var meanCalc = new MeanCalculator();
                var mean = meanCalc.CalculateMean(numbers);
                Console.WriteLine("Mean: {0}", mean);
            }
            catch (Exception)
            {
                Console.WriteLine("Mean: ERROR");
            }
        }

        private void PrintMedian(List<decimal> numbers)
        {
            var medianCalc = new MedianCalculator();
            var median = medianCalc.CalculateMedian(numbers);

            Console.Write("Median: {0}", median);

            Console.WriteLine();
        }

        private void PrintMode(List<decimal> numbers)
        {
            try
            {
                var modeCalc = new ModeCalculator();
                var mode = modeCalc.CalculateMode(numbers);
                Console.WriteLine("Mode: {0}", mode);
            }
            catch (Exception)
            {
                Console.WriteLine("Mode: ERROR");
            }
        }

        

        
    }
}
