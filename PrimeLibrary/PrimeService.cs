using System;

namespace PrimeLibrary
{
    public class PrimeService
    {
        public bool IsPrime(Int64 candidate)
        {            
            if (candidate <= 1) return false;
            if (candidate == 2) return true;
            if (candidate % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(candidate));

            for (Int64 i = 3; i <= boundary; i += 2)
            { 
                if (candidate % i == 0)
                    return false;
            }
            return true;
        }

        public int Factorial(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }
    }

}
