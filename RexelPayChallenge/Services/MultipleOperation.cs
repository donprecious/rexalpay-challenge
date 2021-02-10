using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RexelPayChallenge.Services
{
    public class MultipleOperation :IMultipleOperation
    {
        public string GetValueForMultipleOf3And5()
        {
            return "FizzBuzz";
        } 
        public string GetValueForMultipleOf5()
        {
            return "Buzz";
        }
        public string GetValueForMultipleOf3()
        {
            return "Fizz";
        }

        public string ComputeValue(int number)
        {
        
            if (number % 5 == 0 && number % 3 == 0)
            {
                return GetValueForMultipleOf3And5();
            }
            if (number % 5 == 0 )
            {
                return GetValueForMultipleOf5();
            }
            if (number % 3 == 0 )
            {
                return GetValueForMultipleOf3();
            }

            return number.ToString();
        }
    }
}
