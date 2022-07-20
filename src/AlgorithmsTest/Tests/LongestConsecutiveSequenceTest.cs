using System;
using System.Collections.Generic;
using Xunit;

namespace AlgorithmsTest.Tests
{
    public class LongestConsecutiveSequenceTest
    {
        /// <summary>
        /// Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.
        /// You must write an algorithm that runs in O(n) time.
        /// Input: nums = [100,4,200,1,3,2]
        /// Output: 4
        /// Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
        /// </summary>
        [Fact]
        public void ShouldBeLongestConsecutiveSequence()
        {
            var input = new int[] { 100, 4, 200, 1, 3, 2 };
            var expected = 4;

            // TODO: Make that another input as a parameter
            //var input = new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
            //var expected = 9;

            var result = GetLongestConsecutiveSequence(input);
            

            Assert.Equal(expected, result);
        }

        private int GetLongestConsecutiveSequence(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int maxCount = 0;
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.Contains(nums[i] - 1))
                {
                    counter = 1;
                    int current = 1;

                    while (set.Contains(nums[i] + current))
                    {
                        counter++;
                        current++;
                    }                        
                }
                maxCount = Math.Max(maxCount, counter);
            }
            return maxCount;
        }
    }
}