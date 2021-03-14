using Algorithms.Application;
using Algorithms.Application.Services;
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
            IMakingAnagramsService _makingAnagrams = new MakingAnagramsService();

            Assert.Equal(_makingAnagrams.CheckMakingAnagrams(inputStringA, inputStringB), output);
        }

    }
}
