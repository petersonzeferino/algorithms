using Algorithms.Application;
using Algorithms.Application.Services;
using Xunit;

namespace AlgorithmsTest.Tests
{
    public class MDCTest
    {
        [Fact(DisplayName = "Check number of pairs")]
        public void CheckNumberOfPairsTestSuccess()
        {
            IMDCService _mDCService = new MDCService();
            
            int[] input = new int[] { 2, 4, 6, 8, 10 };
            int output = 2;

            Assert.Equal(_mDCService.ListMDC(input), output);
        }

        [Fact(DisplayName = "Check number of pairs - second test case")]
        public void CheckNumberOfPairsSecondTestSuccess()
        {
            IMDCService _mDCService = new MDCService();

            int[] input = new int[] { 2, 3, 4, 5, 6 };
            int output = 1;

            Assert.Equal(_mDCService.ListMDC(input), output);
        }
    }
}
