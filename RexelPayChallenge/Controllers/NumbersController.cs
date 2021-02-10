using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RexelPayChallenge.Services;
using Swashbuckle.AspNetCore.Annotations;

namespace RexelPayChallenge.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class NumbersController : ControllerBase
    {
        private IMultipleOperation _multipleOperation;
        public NumbersController(IMultipleOperation multipleOperation)
        {
            _multipleOperation = multipleOperation;
        }

        [SwaggerOperation(
            Summary = "Get text for numbers that are multiple of 3 and 5, 3 = Fizz, 5= Buzz , 3&5 = FizzBuzz, non-multiple returns the number", 
            OperationId = "GetNumber"
        )]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), 400)]
        [HttpGet("{number}")]
        public IActionResult GetNumber(int number)
        {
            if (number <= 0 || number > 100)
            {
                return BadRequest("number should be 1 to 100"); 

            }

            var result = _multipleOperation.ComputeValue(number);
            return Ok(result);
        }
    }
}
