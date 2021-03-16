using Algorithms.Application;
using Algorithms.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsTest.Tests
{
    public class TopCompetitorsTest
    {
        [Fact(DisplayName = "Top Competitors with Success")]
        public void TopCompetitorsTestSuccess()
        {
            ITopCompetitorsService _topCompetitorsService = new TopCompetitorsService();

            int numCompetitors = 5;
            int topNCompetitors = 2;
            int numReviews = 3;
            string textTopNCompetitors = String.Empty;

            List<string> competitors =
                new List<string> {
                                            "anacell", "betacellular", "cetracular", "deltacellular", "eurocell"
                                 };

            List<string> reviews =
                new List<string> {
                                            "Best services provided by anacell",
                                            "betacellular has great services",
                                            "anacell provides much better services than all other"
                                 };

            //int numCompetitors = 5;
            //int topNCompetitors = 2;
            //List<string> competitors = new List<string> { "anacell", "betacellular", "cetracular", "deltacellular", "eurocell" };
            //int numReviews = 5;
            //List<string> reviews = new List<string> {
            //    "I love anacell Best services provided by anacell in the town",
            //    "betacellular has great services",
            //    "deltacellular provides much better services than betacellular",
            //    "cetracular is worse than eurocell",
            //    "betacellular is better than deltacellular"};

            List<string> output = new List<string> { "anacell", "betacellular"};

            Assert.Equal(_topCompetitorsService.TopCompetitors(numCompetitors, topNCompetitors, competitors, numReviews, reviews), output);
        }
    }
}
