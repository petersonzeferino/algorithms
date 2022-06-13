using Xunit;

namespace AlgorithmsTest.Tests
{
    public class BinarySearchTest
    {
        /// <summary>
        /// TODO
        /// 704 -> Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.
        /// You must write an algorithm with O(log n) runtime complexity.
        /// </summary>

        [Fact(DisplayName = "Binary Search")]
        public void BinarySearch_GetBinarySearch_ShouldGetBinarySearch()
        {
            //Arrange
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int target = 8;
            int expected = 7;

            //Act
            int actual = GetBinarySearch(nums, target);

            //Assert
            Assert.Equal(expected, actual);
        }

        private int GetBinarySearch(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (nums[middle] == target)
                    return middle;

                else if (nums[middle] > target)
                    right = middle - 1;

                else
                    left = middle + 1;
            }

            return -1;
        }
    }
}