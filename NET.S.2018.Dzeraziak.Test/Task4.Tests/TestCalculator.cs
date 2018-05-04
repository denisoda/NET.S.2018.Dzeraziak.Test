using System;
using System.Collections.Generic;
using NUnit.Framework;
using Task4.InterfaceMethod;

namespace Task4.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean()
        {
            var calculator = new Calculator();
            IAverageCalculator meanMethod = new Mean();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, meanMethod);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            var calculator = new Calculator();
            IAverageCalculator medianMethod = new Median();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, medianMethod);

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}