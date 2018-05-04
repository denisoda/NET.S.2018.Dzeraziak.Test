using System.Collections.Generic;
using System.Linq;

namespace Task4.InterfaceMethod
{
    public class Mean : IAverageCalculator
    {
        public double CalculateAverage(List<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}