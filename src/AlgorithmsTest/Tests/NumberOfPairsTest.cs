using Algorithms.Application;
using Algorithms.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsTest.Tests
{
    public class NumberOfPairsTest
    {
        [Fact(DisplayName = "Check number of pairs")]
        public void CheckNumberOfPairsServiceTestSuccess()
        {
            INumberOfPairsService _numberOfPairsService = new NumberOfPairsService();
            
            int[] input = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int output = 3;

            Assert.Equal(_numberOfPairsService.NumberOfPairs(input), output);
        }
    }
}
