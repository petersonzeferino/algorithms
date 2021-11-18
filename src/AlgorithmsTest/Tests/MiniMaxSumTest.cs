using Algorithms.Application;
using Algorithms.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AlgorithmsTest.Tests
{

    public class MiniMaxSumTest
    {
        [Theory(DisplayName = "MiniMaxSum")]
        [InlineData("1,2,3,4,5", "10,14")]
        [InlineData("256741038,623958417,467905213,714532089,938071625", "2063136757,2744467344")]
        public void MiniMaxSumTestWithSuccess(string param, string result)
        {
            List<int> arr = new List<int>();
            foreach (var item in param.Split(","))
                arr.Add(Convert.ToInt32(item));

            IMiniMaxSumService _miniMaxSumService = new MiniMaxSumService();
            var response = _miniMaxSumService.GetMiniMaxSum(arr);

            var min = response.Min();
            var max = response.Max();

            var isEqual = false;
            var arrResult = result.Split(",");

            if (arrResult[0] == min.ToString() && arrResult[1] == max.ToString())
                isEqual = true;

            Assert.True(isEqual);
        }
    }
}