using Algorithms.Application;
using Algorithms.Application.Services;
using Xunit;

namespace AlgorithmsTest.Tests
{
    public class OddOrEvenTest
    {
        [Theory(DisplayName = "Check value is Even")]
        [InlineData(0, true)]       
        [InlineData(10, true)]
        public void CheckEven(int input, bool output)
        {
            IOddOrEvenService _oddOrEvenService = new OddOrEvenService();

            Assert.Equal(_oddOrEvenService.OddOrEven(input), output);
        }

        [Theory(DisplayName = "Check value is Odd")]
        [InlineData(1, false)]
        [InlineData(5, false)]
        public void CheckOdd(int input, bool output)
        {
            IOddOrEvenService _oddOrEvenService = new OddOrEvenService();

            Assert.Equal(_oddOrEvenService.OddOrEven(input), output);
        }        

    }
}
