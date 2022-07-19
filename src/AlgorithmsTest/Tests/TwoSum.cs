using System;
using System.Collections;
using Xunit;

namespace AlgorithmsTest.Tests
{
    public class TwoSum
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        ///You can return the answer in any order.
        /// </summary>
        [Fact]
        public void ShouldBeTwoSumAndReturnIndexs()
        {
            int[] numbers = { 2, 11, 15, 7 };
            int target = 22;
            int[] expected = { 3, 2 };

            var result = GetTwoSum(numbers, target);

            Assert.Equal(expected, result);
        }

        private int[] GetTwoSum(int[] numbers, int target)
        {
            Hashtable map = new Hashtable();

            for (int i = 0; i < numbers.Length; i++)
            {
                var complement = target - numbers[i];

                if (map.Contains(complement))
                    return new int[] { i, Convert.ToInt16(map[complement]) };

                map.Add(numbers[i], i);
            }

            return default;
        }
    }
}