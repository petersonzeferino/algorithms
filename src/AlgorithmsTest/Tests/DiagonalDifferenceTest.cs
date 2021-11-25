using Algorithms.Application;
using Algorithms.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AlgorithmsTest.Tests
{

    public class DiagonalDifferenceTest
    {
        [Theory(DisplayName = "DiagonalDifference")]
        [MemberData(nameof(GetParameters), parameters: 3)]
        public void DiagonalDifferenceTestWithSuccess(List<List<int>> arr, int expected)
        {
            IDiagonalDifferenceService diagonalDifferenceService = new DiagonalDifferenceService();
            var result = diagonalDifferenceService.CalculeDiagonalDifference(arr);

            Assert.Equal(result, expected);
        }

        public static IEnumerable<object[]> GetParameters(int numberTest)
        {
            var allParams = new List<object[]>
            {
                new object[] {
                    new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 9, 8, 9 } },
                    2
                },
                new object[] {
                    new List<List<int>> { new List<int> { 11, 2, 4 }, new List<int> { 4, 5, 6 }, new List<int> { 10, 8, -12 } },
                    15
                },
                new object[] {
                    new List<List<int>> { new List<int> { -1, 1, -7, -8 }, new List<int> { -10, -8, -5, -2 }, new List<int> { 0, 9, 7, -1 }, new List<int> { 4, 4, -2, 1 } },
                    1
                },
            };

            return allParams.Take(numberTest);
        }
    }
}