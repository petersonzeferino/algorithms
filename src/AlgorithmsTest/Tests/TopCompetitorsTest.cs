using Algorithms.Application;
using Algorithms.Application.Services;
using System;
using System.Collections.Generic;
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

            Assert.Equal(TopCompetitors(numCompetitors, topNCompetitors, competitors, numReviews, reviews), output);
        }

        private List<string> TopCompetitors(int numCompetitors, int topNCompetitors, List<string> competitors, int numReviews, List<string> reviews)
        {
            List<string> result = new List<string>();
            List<int> listQtd = new List<int>();
            int controller = 0;
            int first = 0;
            int second = 0;
            int indexFirst = 0;
            int indexSecond = 0;

            for (int i = 0; i < competitors.Count; i++)
            {
                if (result.Count != 0)
                    controller += 1;

                int qtd = 0;

                for (int p = 0; p < reviews.Count; p++)
                {
                    qtd += reviews[p].Split(competitors[i]).Length - 1;
                }

                listQtd.Add(qtd);
            }

            for (int i = 0; i < listQtd.Count - 1; i++)
            {
                if (i == 0)
                {
                    first = listQtd[i];
                    indexFirst = i;
                }

                if (listQtd[i] < listQtd[i + 1])
                {
                    if (listQtd[i + 1] > first)
                    {
                        first = listQtd[i + 1];
                        indexFirst = i + 1;
                    }

                }
            }

            for (int i = 0; i < listQtd.Count - 1; i++)
            {
                if (i != indexFirst)
                {
                    if (i == 0)
                    {
                        second = listQtd[i];
                        indexSecond = i;
                    }

                    if (i + 1 == indexFirst)
                    {
                        second = listQtd[i];
                        indexSecond = i;
                    }
                    else
                    {
                        if (second == 0)
                        {
                            second = listQtd[i];
                            indexSecond = i;
                        }
                    }

                    if (listQtd[i] < listQtd[i + 1])
                    {
                        second = listQtd[i + 1];
                        indexSecond = i;
                    }

                }
            }

            result.Add(competitors[indexFirst]);
            result.Add(competitors[indexSecond]);

            return result;
        }

    }
}
