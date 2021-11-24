using Algorithms.Application;
using Algorithms.Application.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace AlgorithmsTest.Tests
{

    public class DiagonalDifferenceTest
    {
        [Fact(DisplayName = "DiagonalDifference")]
        //[InlineData("1,2,3", "0.500000,0.333333,0.166667")]
        //[InlineData("1,2,3,-1,-2,-3,0,0", "0.375000,0.375000,0.250000")]
        public void DiagonalDifferenceTestWithSuccess()
        {

            //List<List<int>> arr = new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 9, 8, 9 } };
            List<List<int>> arr = new List<List<int>> { new List<int> { 11, 2, 4 }, new List<int> { 4, 5, 6 }, new List<int> { 10, 8, -12 } };
            //List<List<int>> arr = new List<List<int>> { new List<int> { -1, 1, -7, -8 }, new List<int> { -10, -8, -5, -2 }, new List<int> { 0, 9, 7, -1 }, new List<int> { 4, 4, -2, 1 } };

            int diagonal = 0;
            int inverseDiagonal = 0;
            int capacity = arr.Count - 1;
            
            while (capacity != -1)
            {
                var current = arr[capacity][capacity];
                diagonal += arr[capacity][capacity];
                capacity--;
            }

            capacity = arr.Count - 1;
            int start = 0;

            while (capacity != -1)
            {
                var current = arr[start][capacity];
                inverseDiagonal += arr[start][capacity];
                capacity--;
                start++;
            }

            int result = 0;
            if (diagonal > inverseDiagonal)
                result = Math.Abs(diagonal - inverseDiagonal);
            else
                result = Math.Abs(inverseDiagonal - diagonal);

            //Assert.True(isEqual);            
        }
    }
}