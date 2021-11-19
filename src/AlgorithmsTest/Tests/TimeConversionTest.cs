using Algorithms.Application;
using Algorithms.Application.Services;
using Xunit;

namespace AlgorithmsTest.Tests
{

    public class TimeConversionTest
    {
        [Theory(DisplayName = "TimeConversion")]
        [InlineData("12:01:00PM", "12:01:00")]
        [InlineData("12:01:00AM", "00:01:00")]
        [InlineData("11:59:59PM", "23:59:59")]
        public void TimeConversionTestWithSuccess(string request, string result)
        {
            ITimeConversionService _timeConversionService = new TimeConversionService();
            var response = _timeConversionService.GetTimeConversion(request);

            Assert.Equal(response, result);            
        }

        [Theory(DisplayName = "TimeConversion")]
        [InlineData("12:01:00PM", "12:01:00")]
        [InlineData("12:01:00AM", "00:01:00")]
        [InlineData("11:59:59PM", "23:59:59")]
        public void TimeConversionV2TestWithSuccess(string request, string result)
        {
            ITimeConversionService _timeConversionService = new TimeConversionService();
            var response = _timeConversionService.GetTimeConversionV2(request);

            Assert.Equal(response, result);
        }
    }
}