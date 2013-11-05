using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeanMedianAndMode.Operations.UserInput;
using NUnit.Framework;

namespace MeanMedianAndMode.Tests
{
    [TestFixture]
    public class EntryTests
    {
        [Test]
        public void ConvertCsvReturnsList()
        {
            var entry = new NumberEntry();

            string testData = "1,2 , 3, 4,5";

            var decimalList = entry.ConvertCsvToDecimalList(testData);    

            Assert.AreEqual(new List<decimal>() { 1m, 2m, 3m, 4m, 5m}, decimalList );
        }

        [Test]
        public void ManualEntryReturnsCommaRemovedList()
        {
            var entry = new NumberEntry();

            string testData = "100,32,45,64,24";

            var decimalList = entry.ManualEntry(testData);

            Assert.AreEqual(new List<decimal>() { 100m, 32m, 45m, 64m, 24m }, decimalList);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ManualEntryThrowsExceptionForEmptyString()
        {
            var entry = new NumberEntry();

            string testData = string.Empty;

            entry.ManualEntry(testData);
        }

        [Test]
        public void ReadNumbersFromFileReturnsCommaRemovedList()
        {
            var entry = new NumberEntry();
            string filename = "Numbers.txt";

            var decimalList = entry.ReadNumbersFromFile(filename);

            Assert.AreEqual(new List<string>() { "100", "32", "54", "67", "435" }, decimalList);
        }
    }
}
