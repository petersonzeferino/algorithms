using Algorithms.Application;
using Algorithms.Application.Services.Algorithms;
using System;
using System.Collections.Generic;
using Xunit;

namespace AlgorithmsTest
{
    public class OddOrEvenTest
    {
        [Theory(DisplayName = "Check value is Even")]
        [InlineData(0, true)]       
        [InlineData(10, true)]
        public void CheckEven(int input, bool output)
        {
            IAlgorithmsService _algorithmsService = new AlgorithmsService();

            Assert.Equal(_algorithmsService.OddOrEven(input), output);
        }

        [Theory(DisplayName = "Check value is Odd")]
        [InlineData(1, false)]
        [InlineData(5, false)]
        public void Checkodd(int input, bool output)
        {
            IAlgorithmsService _algorithmsService = new AlgorithmsService();

            Assert.Equal(_algorithmsService.OddOrEven(input), output);
        }        

    }
}
