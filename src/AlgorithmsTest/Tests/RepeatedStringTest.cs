using Algorithms.Application;
using Algorithms.Application.Services;
using Xunit;

namespace AlgorithmsTest.Tests
{
    public class RepeatedStringTest
    {
        [Theory(DisplayName = "Check repeated string")]
        [InlineData("aba", 10, 7)]
        [InlineData("a", 1000000000000, 1000000000000)]
        [InlineData("kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm", 736778906400, 51574523448)]
        public void CheckRepeatedString(string inputString, long inputNumberRepeat, long output)
        {
            IRepeatedStringService _repeatedStringService = new RepeatedStringService();

            Assert.Equal(RepeatedString(inputString, inputNumberRepeat), output);
        }

        private long RepeatedString(string s, long n)
        {
            long size = s.Length;
            long repeated = n / size;
            long left = n - (size * repeated);
            int extra = 0;

            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (s[i] == 'a')
                    ++count;
            }

            for (int i = 0; i < left; i++)
            {
                if (s[i] == 'a')
                    ++extra;
            }

            repeated = (repeated * count) + extra;

            return repeated;
        }
    }
}
