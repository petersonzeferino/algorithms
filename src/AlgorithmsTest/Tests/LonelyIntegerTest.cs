﻿using Algorithms.Application;
using Algorithms.Application.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace AlgorithmsTest.Tests
{

    public class LonelyIntegerTest
    {
        [Theory(DisplayName = "LonelyInteger")]
        [InlineData("1,2,3,4,3,2,1", "4")]
        public void LonelyIntegerTestWithSuccess(string request, string result)
        {
            List<int> arr = new List<int>();
            foreach (var item in request.Split(","))
                arr.Add(Convert.ToInt32(item));

            ILonelyIntegerService _lonelyIntegerService = new LonelyIntegerService();
            var response = _lonelyIntegerService.GetLonelyInteger(arr);

            Assert.Equal(response, Convert.ToInt32(result));
        }
    }
}