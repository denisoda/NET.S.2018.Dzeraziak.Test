using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4.InterfaceMethod
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, IAverageCalculator avgCalculator)
        {
            if (values == null || avgCalculator == null)
            {
                throw  new ArgumentNullException();
            }

            return avgCalculator.CalculateAverage(values);
        }
    }
}

