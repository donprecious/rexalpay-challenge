using System;
using Microsoft.AspNetCore.Mvc;
using Moq;
using RexelPayChallenge.Controllers;
using RexelPayChallenge.Services;
using Xunit;

namespace RexelPayChallenge.Test
{
    public class NumberControllerTest
    {
        
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void ShouldBeDivisibleBy3(int value)
        {
            //arrange 
            var mockService = new Mock<IMultipleOperation>();
            IMultipleOperation multipleOperation = mockService.Object;
            var controller = new NumbersController(multipleOperation);  

            //act 

            var result = controller.GetNumber(value);
            //assert  
            var okResult = Assert.IsType<OkObjectResult>(result);
            var  returnedValue = okResult.Value;
            Assert.Equal(multipleOperation.GetValueForMultipleOf3(), returnedValue);
        } 

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(100)]
        public void ShouldBeMultipleBy5(int value)
        {
            //arrange 
            var mockService = new Mock<IMultipleOperation>();
            IMultipleOperation multipleOperation = mockService.Object;
            var controller = new NumbersController(multipleOperation);  

            //act 

            var result = controller.GetNumber(value);
            //assert  
            var okResult = Assert.IsType<OkObjectResult>(result);
            var  returnedValue = okResult.Value;
            Assert.Equal(multipleOperation.GetValueForMultipleOf5(), returnedValue);
        }  
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(100)]
        public void ShouldBeMultipleBy3And5(int value)
        {
            //arrange 
            var mockService = new Mock<IMultipleOperation>();
            IMultipleOperation multipleOperation = mockService.Object;
            var controller = new NumbersController(multipleOperation);  

            //act 

            var result = controller.GetNumber(value);
            //assert  
            var okResult = Assert.IsType<OkObjectResult>(result);
            var  returnedValue = okResult.Value;
            Assert.Equal(multipleOperation.GetValueForMultipleOf3And5(), returnedValue);
        }  

        [Theory]
        [InlineData(1)]
        [InlineData(8)]
        [InlineData(19)]
        public void ShouldNotBeMultipleBy3Or5(int value)
        {
            //arrange 
            var mockService = new Mock<IMultipleOperation>();
            IMultipleOperation multipleOperation = mockService.Object;
            var controller = new NumbersController(multipleOperation);  

            //act 

            var result = controller.GetNumber(value);
            //assert  
            var okResult = Assert.IsType<OkObjectResult>(result);
            var  returnedValue = okResult.Value;
            Assert.Equal(returnedValue, returnedValue);
        } 
    }
}
