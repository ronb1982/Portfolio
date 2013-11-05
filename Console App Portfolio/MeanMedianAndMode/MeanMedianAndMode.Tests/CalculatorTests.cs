using System;
using System.Collections.Generic;
using System.Linq;
using MeanMedianAndMode.Operations.Calculations;
using NUnit.Framework;

namespace MeanMedianAndMode.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void CalculateMeanReturnsAverage()
        {
            var calculator = new MeanCalculator();

            var testData = new List<decimal>();
            testData.Add(10);
            testData.Add(20);
            testData.Add(30);

            var mean = calculator.CalculateMean(testData);

            Assert.AreEqual(20m,mean);
           
        }

        [Test]
        [ExpectedException(typeof (ArgumentException))]
        public void CalculateMeanReturnsExceptionForEmptyList()
        {
            var calculator = new MeanCalculator();

            var testData = new List<decimal>();

            calculator.CalculateMean(testData);
        }

        [Test]
        [ExpectedException(typeof (ArgumentException))]
        public void CalculateMedianReturnsExceptionForEmptyList()
        {
            var medianCalculator = new MedianCalculator();

            var testData = new List<decimal>();

            medianCalculator.CalculateMedian(testData);
        }

        [Test]
        public void CalculateMedianReturnsOneNumber()
        {
            var medianCalculator = new MedianCalculator();

            var testData = new List<decimal>();
            testData.Add(1);
            testData.Add(2);
            testData.Add(3);

            var median = medianCalculator.CalculateMedian(testData);

            Assert.AreEqual("2", median);
        }

        [Test]
        public void CalculateMedianReturnsTwoNumbers()
        {
            var medianCalculator = new MedianCalculator();

            var testData = new List<decimal>();
            testData.Add(22);
            testData.Add(44);
            testData.Add(56);
            testData.Add(100);

            var median = medianCalculator.CalculateMedian(testData);

            Assert.AreEqual("50", median);
        }

        [Test]
        public void CalculateModeReturnsMostCommon()
        {
            var modeCalculator = new ModeCalculator();

            var testData = new List<decimal>();

            testData.Add(1);
            testData.Add(1);
            testData.Add(2);
            testData.Add(3);
            testData.Add(3);
            testData.Add(3);

            var mode = modeCalculator.CalculateMode(testData);
            
            Assert.AreEqual("3", mode);
        }

        [Test]
        public void CalculateModeReturnsMostCommon2()
        {
            var modeCalculator = new ModeCalculator();

            var testData = new List<decimal>();

            testData.Add(199);
            testData.Add(254);
            testData.Add(199);
            testData.Add(233);
            testData.Add(998);
            testData.Add(199);

            var mode = modeCalculator.CalculateMode(testData);

            Assert.AreEqual("199", mode);
        }

        [Test] // all dictionary values equal 1
        public void CalculateModeReturnsNoMode()
        {
            var modeCalculator = new ModeCalculator();
            var testData = new List<decimal>();

            testData.Add(1);
            testData.Add(2);
            testData.Add(3);

            var mode = modeCalculator.CalculateMode(testData);

            Assert.AreEqual("none", mode);

        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateModeReturnsNothing()
        {
            var modeCalculator = new ModeCalculator();

            var testData = new List<decimal>();

            modeCalculator.CalculateMode(testData);
        }

    }
}
