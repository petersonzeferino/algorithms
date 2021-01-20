using Algorithms.Application;
using Algorithms.Application.Services.Algorithms;
using System;
using System.Collections.Generic;
using Xunit;


namespace AlgorithmsTest
{
    public class RepeatedStringTest
    {
        [Theory(DisplayName = "Check value is palindrome")]
        [InlineData("aba", 10, 7)]
        //[InlineData("a", 1000000000000, 1000000000000)]
        //[InlineData("kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm", 736778906400, 51574523448)]
        public void CheckRepeatedString(string inputString, long inputNumberRepeat, long output)
        {
            IAlgorithmsService _algorithmsService = new AlgorithmsService();

            Assert.Equal(_algorithmsService.RepeatedString(inputString, inputNumberRepeat), output);
        }
    }
}
