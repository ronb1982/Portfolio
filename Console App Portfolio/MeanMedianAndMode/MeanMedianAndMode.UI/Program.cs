using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeanMedianAndMode.Operations.UserInput;

namespace MeanMedianAndMode.UI
{
    class Program
    {
        public static string Choice { get; set; }

        static void Main(string[] args)
        {
            var printer = new ResultPrinter();

            var numbers = new List<decimal>();

            var input = new NumberEntry();

            while (true)
            {

                Choice = AskUserForInput().ToUpper();

                if (Choice != "I" && Choice != "F")
                {
                    Console.WriteLine("Invalid input. Try again.");
                }

                if (Choice == "I")
                {
                    // read numbers manually
                    Console.Write("Enter a set of numbers (separated by commas): ");
                    string numberSet = Console.ReadLine();

                    var decimals = input.ManualEntry(numberSet);

                    foreach (decimal d in decimals)
                    {
                        numbers.Add(d);
                    }

                    printer.PrintResults(numbers);
                    break;
                }
                
                do
                {

                    string filename =
                        @"C:\Users\apprentice\Documents\Visual Studio 2012\Projects\MeanMedianAndMode\MeanMedianAndMode.Operations\bin\Debug\Numbers.txt";

                    //Console.Write("Enter filename: ");
                    //string filename = path + Console.ReadLine();

                    if (!File.Exists(filename))
                        Console.WriteLine("File does not exist. Try again!");

                    else
                    {
                        var numbersAsString = input.ReadNumbersFromFile(filename);

                        foreach (string num in numbersAsString)
                        {
                            numbers.Add(decimal.Parse(num));
                        }

                        printer.PrintResults(numbers);

                        break;
                    }

                } while (true);
            }
            
            Console.ReadLine();

        }

        private static string AskUserForInput()
        {
            Console.WriteLine("Type 'I' to input numbers or 'F' to read from file.");
            string choice = Console.ReadLine();

            return choice;
        }
    }
}
