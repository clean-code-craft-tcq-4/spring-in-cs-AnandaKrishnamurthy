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
        IAlerter[] alerters;
        double MaxThresholds;
        public StatsAlerter(double maxThresholds, IAlerter[] alerters)
        {
            MaxThresholds = maxThresholds;
        }


        public void checkAndAlert(List<double> Allerts)
        {
            if (MaxThresholds >= Allerts.Max())
            {
                LEDAlert lEDAlert = new LEDAlert();
                lEDAlert.Alert();
                EmailAlert emailAlert = new EmailAlert();
                emailAlert.Alert();
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
