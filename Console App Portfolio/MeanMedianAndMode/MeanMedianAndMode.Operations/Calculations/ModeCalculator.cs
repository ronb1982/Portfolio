using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanMedianAndMode.Operations.Calculations
{
    public class ModeCalculator
    {
        public string CalculateMode(List<decimal> numbers)
        {
            decimal max = 0;
            string result = "";

            var numDictionary = new Dictionary<decimal, int>();

            AddToDictionary(numbers, numDictionary);

            if(numDictionary.Count == 0)
                throw new ArgumentException("No numbers given!", "numbers");

            if (numDictionary.All(d => d.Value == 1))
                return "none";

            foreach (KeyValuePair<decimal, int> pair in numDictionary)
            {
                if (pair.Value > max)
                {
                    result = "";
                    max = pair.Value;
                    result += string.Format("{0},", pair.Key);
                }

                else if (pair.Value == max)
                    result += string.Format("{0},", pair.Key);

            }

            return result.Trim(',');

        }

        private void AddToDictionary(List<decimal> numbers, Dictionary<decimal, int> numDictionary)
        {
            foreach (var number in numbers)
            {
                if (!numDictionary.ContainsKey(number))
                    numDictionary.Add(number, 1);

                else
                    numDictionary[number]++;
            }
        }
    }
}
