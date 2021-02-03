using Algorithms.Application;
using Algorithms.Application.Services.Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class MakingAnagramsTest
    {
        [Theory(DisplayName = "Check number of deletions for Making Anagrams")]
        [InlineData("cde", "abc", 4)]
        [InlineData("fcrxzwscanmligyxyvym", "jxwtrhvujlmrpdoqbisbwhmgpmeoke", 30)]
        [InlineData("showman", "woman", 2)]
        public void CheckMakingAnagramsTestSuccess(string inputStringA, string inputStringB, int output)
        {
            IAlgorithmsService _algorithmsService = new AlgorithmsService();

            Assert.Equal(_algorithmsService.CheckMakingAnagrams(inputStringA, inputStringB), output);
        }

    }
}
