using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsTest.Tests
{
    public class LongestSubstring
    {
        /// <summary>
        /// Given a string S. The task is to find the length of the longest substring without repeating characters.
        /// A substring is a contiguous sequence of characters within a string. For example – “view” is a substring of the string “Interviewbit”.
        /// Input: S = “abcabcbb”
        /// Output: 3
        /// Explanation:
        /// “abc” is the longest substring without repeating characters among all the substrings.
        /// </summary>
        [Fact]
        public void ShouldLongestSubstringWithoutRepeatingCharactersWithSucess()
        {
            var S = "abcabcbb";
            var expected = 3;

            var result = GetLongestSubstring(S);           

            Assert.Equal(expected, result);
        }

        private int GetLongestSubstring(string input)
        {
            HashSet<char> map = new HashSet<char>();
            int maxSize = 0;
            int left = 0;
            int right = 0;

            while (right < input.Length)
            {
                if (!map.Contains(input[right]))
                {
                    map.Add(input[right]);
                    right++;
                    maxSize = Math.Max(maxSize, map.Count);
                }
                else
                {
                    map.Remove(input[left]);
                    left++;
                }
            }

            return maxSize;
        }
    }
}