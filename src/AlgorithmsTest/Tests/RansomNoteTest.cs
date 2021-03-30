using Algorithms.Application;
using Algorithms.Application.Services;
using Xunit;

namespace AlgorithmsTest.Tests
{
    public class RansomNoteTest
    {
        [Theory(DisplayName = "Check ransom note")]
        [InlineData("give me one grand today night", "give one grand today", "Yes")]
        [InlineData("two times three is not four", "two times two is four", "No")]
        [InlineData("ive got a lovely bunch of coconuts", "ive got some coconuts", "No")]
        public void RansomNoteTestSuccess(string s1, string s2, string result)
        {
            IRansomNoteService _ransomNoteService = new RansomNoteService();

            Assert.Equal(_ransomNoteService.CheckRansomNote(s1, s2), result);            
        }
    }
}
