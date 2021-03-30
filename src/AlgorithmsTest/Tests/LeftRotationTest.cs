using Algorithms.Application;
using Algorithms.Application.Services;
using Xunit;

namespace AlgorithmsTest.Tests
{
    public class LeftRotationTest
    {
        [Fact(DisplayName = "Check number of left rotations")]
        public void CheckNumberOfLestRotationTestSuccess()
        {
            ILeftRotationService _leftRotationService = new LeftRotationService();

            int[] input = new int[] { 1, 2, 3, 4, 5 };
            int numberOfRotation = 4;
            int[] output = new int[] { 5, 1, 2, 3, 4 };

            Assert.Equal(_leftRotationService.ArrayLeftRotation(input, numberOfRotation), output);
        }


        

    }
}
