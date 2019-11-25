using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeLibrary
{
    public class ManTimeService
    {
        public double CalculateManHours(int hours, int noOfMen)
        {            
            return Convert.ToDouble(hours) / Convert.ToDouble(noOfMen);
        }
    }
}
