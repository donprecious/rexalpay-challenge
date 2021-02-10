using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RexelPayChallenge.Services
{
   public interface IMultipleOperation
   {
       string GetValueForMultipleOf3And5();
       string GetValueForMultipleOf5();
       string GetValueForMultipleOf3();
       string ComputeValue(int number);
   }
}
