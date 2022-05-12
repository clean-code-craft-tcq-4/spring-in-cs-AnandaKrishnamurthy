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
        
        
        
         public interface IAlerter
    {
        void LEDAlert();
        void EmailAlert();
    }

    public class StatsAlerter: IAlerter
    {
       bool ledGlows;
        bool emailSent;
        public double maxThreshold;      
        
        public StatsAlerter(double MaxThreshold, IAlerter[] Alerters)
        {
            maxThreshold = MaxThreshold;
        }
         public void LEDAlert()
         {           
                 ledGlows = true;
         }
         public void EmailAlert()
         {            
                emailSent = true;
         } 
        public double checkAndAlert(List<double> Allerts)
        {
            if(Allerts.Max()>= maxThreshold) {
                EmailAlert();
                LEDAlert();
            }
                return Allerts.Max();         
        }
    }
        
        
        
    }
}
