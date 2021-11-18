using Algorithms.Application;
using Algorithms.Application.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace AlgorithmsTest.Tests
{

    public class PlusMinusTest
    {

        [Theory(DisplayName = "PlusMinus")]
        [InlineData("4,3,-9,0,4,1")]
        [InlineData("1,2,3,-1,-2,-3,0,0")]        
        public void PlusMinusTestWithSuccess(string param)
        {
            IPlusMinusService _plusMinusService = new PlusMinusService();

            List<int> arr = new List<int>();
            foreach (var item in param.Split(","))
                arr.Add(Convert.ToInt32(item));

            var result = _plusMinusService.GetPlusMinus(arr);

            Console.WriteLine($"{result[0]}{Environment.NewLine}" +
                  $"{result[1]}{Environment.NewLine}" +
                  $"{result[2]}");
        }
    }
}