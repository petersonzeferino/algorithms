using System;
using Xunit;

namespace AlgorithmsTest.Tests
{
    /// <summary>
    /// 53 - Given an integer array nums, find the contiguous subarray(containing at least one number) which has the largest sum and return its sum.
    /// A subarray is a contiguous part of an array.
    /// </summary>
    public class MaximumSubarrayTest
    {        

        [Fact(DisplayName = "Maximum Subarray")]
        public void MaximumSubarray_GetMaximumSubarray_ShouldGetMaximumSubarrarySum()
        {
            //Arrange
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //int[] expected = new int[] { 4, -1, 2, 1 };
            var expected = 6;

            //Fact
            var result = GetMaximumSubarraySum(nums);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "Maximum Subarray with one item")]
        public void MaximumSubarray_GetMaximumSubarray_ShouldGetMaximumSubarrarySumWithOneItem()
        {
            //Arrange
            int[] nums = new int[] { 1 };
            var expected = 1;

            //Fact
            var result = GetMaximumSubarraySum(nums);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "Maximum Subarray with all itens")]
        public void MaximumSubarray_GetMaximumSubarray_ShouldGetMaximumSubarrarySumAllItens()
        {
            //Arrange
            int[] nums = new int[] { 5, 4, -1, 7, 8 };
            var expected = 23;

            //Fact
            var result = GetMaximumSubarraySum(nums);

            //Assert
            Assert.Equal(expected, result);
        }

        private int GetMaximumSubarraySum(int[] nums)
        {
            //Dynamic Programming, Kadane's Algorithm
            var currentSubArrary = nums[0];
            var maxSubArrary = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currentSubArrary = Math.Max(nums[i], currentSubArrary + nums[i]);
                maxSubArrary = Math.Max(maxSubArrary, currentSubArrary);
            }

            return maxSubArrary;
        }
    }
}