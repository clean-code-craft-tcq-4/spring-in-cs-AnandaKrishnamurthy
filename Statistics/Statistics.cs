using System;
using System.Collections.Generic;
using System.Linq;

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
        
        public interface IAlerter
    {
       void  Alert();
    }

    public class StatsAlerter 
    {
        IAlerter[] Alerters;
        double MaxThresholds;
        public StatsAlerter(double maxThresholds, IAlerter[] alerters)
        {
            MaxThresholds = maxThresholds;
            Alerters = alerters;
        }


        public void checkAndAlert(List<double> Allerts)
        {
            if (Allerts.Max() >= MaxThresholds)
            {
                Alerters[0].Alert();
                Alerters[1].Alert();

            }
        }
      
    }

 public class LEDAlert: IAlerter
                {
                    public bool ledGlows;
                    public void  Alert()
                    {
                        ledGlows = true;
                    }
                }
            public class EmailAlert: IAlerter
                {
                public  bool emailSent;
                    public void Alert()
                    {
                        emailSent = true;
                    }
                }
 
}
