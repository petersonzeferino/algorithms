using Algorithms.Application;
using Algorithms.Application.Services.Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class PalindromeTest
    {
        [Theory(DisplayName = "Check value is palindrome")]
        [InlineData("Red rum, sir, is murder", true)]
        [InlineData("A nut for a jar of tuna", true)]
        [InlineData("A Santa at Nasa", true)]
        [InlineData("A car, a man, a maraca", true)]
        public void CheckPalindromeWithSuccess(string input, bool output)
        {
            IAlgorithmsService _algorithmsService = new AlgorithmsService();

            Assert.Equal(_algorithmsService.CheckPalindrome(input), output);
        }
    }
}
