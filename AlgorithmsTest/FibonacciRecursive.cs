using Algorithms.Application;
using Algorithms.Application.Services.Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class FibonacciRecursive
    {
        [Theory(DisplayName = "Check fibonacci recursive")]
        [InlineData(3,2)]
        [InlineData(6, 8)]
        public void CheckFibonacciRecursiveWithSuccess(int input, int output)
        {
            IAlgorithmsService _algorithmsService = new AlgorithmsService();

            Assert.Equal(_algorithmsService.CheckFibonacciRecursive(input), output);
        }
    }
}
