using Xunit;

namespace AlgorithmsTest.Tests
{
    public class SearchInsertTest
    {
        [Fact(DisplayName = "Search insert found index")]
        public void SearchInsert_FindIndex_ShouldFindTargeInArray()
        {
            //Arrange
            int[] input = new int[] { 1, 3, 5, 6 };
            int target = 5;
            int output = 2;

            //Fact
            var result = GetInformedIndex(input, target);

            //Assert
            Assert.Equal(output, result);
        }

        [Fact(DisplayName = "Search insert not found index enter in the middle")]
        public void SearchIndex_NotFindIndex_ShoudlReturnIndexHowEnterInTheMiddle()
        {
            //Arrange
            int[] input = new int[] { 1, 3, 5, 6 };
            int target = 2;
            int output = 1;

            //Fact
            var result = GetInformedIndex(input, target);

            //Assert
            Assert.Equal(output, result);
        }

        [Fact(DisplayName = "Search insert not found index enter in the final")]
        public void SearchIndex_NotFindIndex_ShoudlReturnIndexHowEnterInTheFinal()
        {
            //Arrange
            int[] input = new int[] { 1, 3, 5, 6 };
            int target = 7;
            int output = 4;

            //Fact
            var result = GetInformedIndex(input, target);

            //Assert
            Assert.Equal(output, result);
        }

        [Fact(DisplayName = "Search insert not found index enter in the begin")]
        public void SearchIndex_NotFindIndex_ShoudlReturnIndexHowEnterInTheBegin()
        {
            //Arrange
            int[] input = new int[] { 1, 3, 5, 6 };
            int target = 0;
            int output = 0;

            //Fact
            var result = GetInformedIndex(input, target);

            //Assert
            Assert.Equal(output, result);
        }

        private int GetInformedIndex(int[] nums, int target)
        {
            if (nums[nums.Length - 1] < target)
                return nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return i;
                
                if (nums[i] > target)
                    return i;
            }

            return default;
        }
    }
}