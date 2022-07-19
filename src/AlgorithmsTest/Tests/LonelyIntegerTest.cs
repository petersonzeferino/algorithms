using Algorithms.Application;
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

            var response = GetLonelyInteger(arr);

            Assert.Equal(response, Convert.ToInt32(result));
        }

        private int GetLonelyInteger(List<int> arr)
        {
            var response = 0;
            foreach (var item in arr)
            {
                if (arr.FindAll(x => x == item).Count == 1)
                {
                    response = item;
                    break;
                }
            }

            return response;
        }
    }
}