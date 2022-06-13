using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsTest.Tests
{
    /// <summary>
    /// 283 - Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    /// Note that you must do this in-place without making a copy of the array.
    /// </summary>
    public class MoveZerosTest
    {
        [Fact]
        public void MoveZeros()
        {
            int[] input = new int[] { 0, 1, 0, 3, 12 };
            int[] expected = new int[] { 1, 3, 12, 0, 0 };
            int[] actual = GetMoveZeros(input);
            Assert.Equal(expected, actual);
        }

        public int[] GetMoveZeros(int[] nums)
        {
            int lastZero = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    int aux = nums[lastZero];
                    nums[lastZero] = nums[i];
                    nums[i] = aux;
                    lastZero++;
                }
            }

            return nums;
        }
    }
}
