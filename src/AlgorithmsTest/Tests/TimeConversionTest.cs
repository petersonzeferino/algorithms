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
            var response = GetTimeConversion(request);

            Assert.Equal(response, result);            
        }

        [Theory(DisplayName = "TimeConversion")]
        [InlineData("12:01:00PM", "12:01:00")]
        [InlineData("12:01:00AM", "00:01:00")]
        [InlineData("11:59:59PM", "23:59:59")]
        public void TimeConversionV2TestWithSuccess(string request, string result)
        {
            var response = GetTimeConversionV2(request);

            Assert.Equal(response, result);
        }

        private string GetTimeConversion(string s)
        {
            //var hour = s[..2];
            //var period = s[(s.Length - 2)..];

            var hour = s.Substring(0, 2);
            var period = s.Substring(s.Length - 2);
            string response;

            if (period == "PM")
            {
                //response = hour switch {
                //    "01" => "13",
                //    "02" => "14",
                //    "03" => "15",
                //    "04" => "16",
                //    "05" => "17",
                //    "06" => "18",
                //    "07" => "19",
                //    "08" => "20",
                //    "09" => "21",
                //    "10" => "22",
                //    "11" => "23",
                //    _ => hour
                //};

                switch (hour)
                {
                    case "01":
                        response = "13";
                        break;
                    case "02":
                        response = "14";
                        break;
                    case "03":
                        response = "15";
                        break;
                    case "04":
                        response = "16";
                        break;
                    case "05":
                        response = "17";
                        break;
                    case "06":
                        response = "18";
                        break;
                    case "07":
                        response = "19";
                        break;
                    case "08":
                        response = "20";
                        break;
                    case "09":
                        response = "21";
                        break;
                    case "10":
                        response = "22";
                        break;
                    case "11":
                        response = "23";
                        break;
                    default:
                        response = hour;
                        break;
                }
            }
            else
            {
                if (hour == "12")
                    response = "00";
                else
                    response = hour;
            }

            //response = $"{response}:{s.Split(":")[1]}:{s.Split(":")[2][..2]}";

            string minutes = s.Substring(3, 2);
            string seconds = s.Substring(6, 2);

            response = $"{response}:{minutes}:{seconds}";
            return response;
        }

        private string GetTimeConversionV2(string s)
        {
            var hour = s[..2];
            var period = s[(s.Length - 2)..];
            string response;

            if (period == "PM")
            {
                response = hour switch
                {
                    "01" => "13",
                    "02" => "14",
                    "03" => "15",
                    "04" => "16",
                    "05" => "17",
                    "06" => "18",
                    "07" => "19",
                    "08" => "20",
                    "09" => "21",
                    "10" => "22",
                    "11" => "23",
                    _ => hour
                };
            }
            else
            {
                if (hour == "12")
                    response = "00";
                else
                    response = hour;
            }

            string minutes = s.Split(":")[1];
            string seconds = s.Split(":")[2][..2];

            response = $"{response}:{minutes}:{seconds}";
            return response;
        }
    }
}