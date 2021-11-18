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
        [InlineData("4,3,-9,0,4,1", "0.500000,0.333333,0.166667")]
        [InlineData("1,2,3,-1,-2,-3,0,0", "0.375000,0.375000,0.250000")]
        public void PlusMinusTestWithSuccess(string param, string result)
        {
            IPlusMinusService _plusMinusService = new PlusMinusService();

            List<int> arr = new List<int>();
            foreach (var item in param.Split(","))
                arr.Add(Convert.ToInt32(item));

            var response = _plusMinusService.GetPlusMinus(arr);

            Console.WriteLine($"{response[0]}{Environment.NewLine}" +
                  $"{response[1]}{Environment.NewLine}" +
                  $"{response[2]}");

            var isEqual = false;
            var arrResult = result.Split(",");
            for (int i = 0; i < response.Length; i++)
            {
                if (response[i] == arrResult[i])
                    isEqual = true;
            }

            Assert.True(isEqual);            
        }
    }
}