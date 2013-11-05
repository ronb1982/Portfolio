using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanMedianAndMode.Operations.UserInput
{
    public class NumberEntry
    {
        public List<decimal> ManualEntry(string numberSet)
        {
            if (string.IsNullOrEmpty(numberSet))
            {
                throw new ArgumentException("Please input a set of numbers.");
            }

            return ConvertCsvToDecimalList(numberSet);
        }

        public List<string> ReadNumbersFromFile(string filename)
        {
            List<string> lines = new List<string>();
            var result = new List<string>();


            lines = File.ReadAllLines(filename).ToList();

            var nums = new List<decimal>();

            foreach (string line in lines)
            {
                nums = ConvertCsvToDecimalList(line);
            }

            foreach (decimal num in nums)
            {
                result.Add(num.ToString());
            }

            return result;
            
        }


        public List<decimal> ConvertCsvToDecimalList(string numberString)
        {
            string[] numbers = new string[numberString.Length];

            if (numberString.Contains(" "))
            {
                numberString.Replace(" ", string.Empty);
            }

            if (numberString.Contains(","))
            {
                numbers = numberString.Split(',');
            }

            List<decimal> result = numbers.Select(decimal.Parse).ToList();

            return result;
        }


    }
}
