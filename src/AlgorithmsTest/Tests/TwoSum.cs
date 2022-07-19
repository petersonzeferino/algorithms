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

        /// <summary>
        /// Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number. Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.
        /// Return the indices of the two numbers, index1 and index2, added by one as an integer array[index1, index2] of length 2.
        /// The tests are generated such that there is exactly one solution.You may not use the same element twice.
        /// Your solution must use only constant extra space.
        /// </summary>
        [Fact]
        public void ShouldBeTwoSumAndReturnIndexsInInputArrayIsSorted()
        {
            int[] numbers = { 2, 7, 11, 15 };
            int target = 9;
            int[] expected = { 1, 2 };

            var result = GetTwoSumSorted(numbers, target);

            Assert.Equal(expected, result);
        }

        private int[] GetTwoSumSorted(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            do
            {
                int sum = numbers[left] + numbers[right];
                
                if(sum == target)
                    return new int[] { left + 1 , right + 1 };

                if (sum > target)
                    right--;

                else
                    left++;

            } while (true);

            return default;
        }
    }
}