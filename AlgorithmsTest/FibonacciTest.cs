using Algorithms.Application;
using Algorithms.Application.Services;
using Algorithms.Application.Services.Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class FibonacciTest
    {
        [Theory(DisplayName = "Check fibonacci recursive")]
        [InlineData(3,2)]
        [InlineData(6, 8)]
        public void CheckFibonacciRecursiveWithSuccess(int input, int output)
        {
            IFibonacciService _fibonacciService = new FibonacciService();

            Assert.Equal(_fibonacciService.CheckFibonacciRecursive(input), output);
        }
    }
}
