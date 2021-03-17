using Algorithms.Application;
using Algorithms.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace AlgorithmsTest.Tests
{
    
    public class TwoStringsTest
    {

        [Theory(DisplayName = "Check two strings")]
        [InlineData("beetroot", "sandals", "NO")]
        //[InlineData("and", "art", "YES")]
        //[InlineData("hackerrankcommunity", "cdecdecdecde", "YES")]
        public void CheckTwoStringsWithSuccess(string s1, string s2, string result)
        {
            ITwoStringsService _twoStringsService = new TwoStringsService();

            Assert.Equal(_twoStringsService.CheckTwoStrings(s1,s2), result);
        }

    }
}
