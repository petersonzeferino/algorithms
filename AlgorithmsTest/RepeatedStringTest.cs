﻿using Algorithms.Application;
using Algorithms.Application.Services;
using Xunit;

namespace AlgorithmsTest
{
    public class RepeatedStringTest
    {
        [Theory(DisplayName = "Check value is palindrome")]
        [InlineData("aba", 10, 7)]
        [InlineData("a", 1000000000000, 1000000000000)]
        [InlineData("kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm", 736778906400, 51574523448)]
        public void CheckRepeatedString(string inputString, long inputNumberRepeat, long output)
        {
            IRepeatedStringService _repeatedStringService = new RepeatedStringService();

            Assert.Equal(_repeatedStringService.RepeatedString(inputString, inputNumberRepeat), output);
        }
    }
}
