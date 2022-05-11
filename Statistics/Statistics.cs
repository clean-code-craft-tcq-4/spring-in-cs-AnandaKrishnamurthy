using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public double average, max,min;
        public double CalculateStatistics(List<double> numbers) {
            //Implement statistics here
            average= numbers.Average();
            max=numbers.Max();
            min=numbers.Min();
            return 0.0;
        }
    }
}
