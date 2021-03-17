using Algorithms.Application;
using Algorithms.Application.Services;
using Xunit;

namespace AlgorithmsTest.Tests
{
    public class AlternatingCharactersTest
    {
        [Theory(DisplayName = "Check number of deletions for alternating characters")]
        [InlineData("AAAA", 3)]
        [InlineData("BBBBB", 4)]
        [InlineData("ABABABAB", 0)]
        [InlineData("BABABA", 0)]
        [InlineData("AAABBB", 4)]
        public void CheckAlgorithmsCharactersSuccess(string input, int output)
        {
            IAlternatingCharactersService _alternatingCharactersService = new AlternatingCharactersService();

            Assert.Equal(_alternatingCharactersService.CheckAlgorithmsCharacter(input), output);
        }

    }
}
