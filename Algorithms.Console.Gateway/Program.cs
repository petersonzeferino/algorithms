using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                                "SELECT THE ALGORITHMS AND PRESS ENTER" +
                                "\r\n" +
                                "1 - MDC " +
                                "\r\n" +
                                "2 - Calcule States " +
                                "\r\n" +
                                "3 - Top Competitors "
                             );

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    int resultMdcList;

                    //int[] numberList = new int[] { 2, 3, 4, 5, 6 };
                    int[] numberList = new int[] { 2, 4, 6, 8, 10 };

                    resultMdcList = mdcList(numberList);

                    Console.WriteLine("Result of MDC: " + resultMdcList.ToString());

                    break;
                case "2":
                    int[] resultCalculeStates;
                    string textResultCalculeStates = String.Empty;

                    //int[] states = new int[] { 1, 1, 1, 0, 1, 1, 1, 1 };
                    //int days = 2;

                    int[] states = new int[] { 1, 0, 0, 0, 0, 1, 0, 0 };
                    int days = 1;

                    resultCalculeStates = calculeStates(states, days);

                    foreach (var item in resultCalculeStates)
                    {
                        textResultCalculeStates += item + " ";
                    }

                    Console.WriteLine("Result of States: " + textResultCalculeStates);

                    break;
                case "3":
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

                    var resultTopNCompetitors = TopNCompetitors(numCompetitors, topNCompetitors, competitors, numReviews, reviews);

                    foreach (var item in resultTopNCompetitors)
                    {
                        textTopNCompetitors += item + " ";
                    }

                    Console.WriteLine("Result of Top Competitors: " + textTopNCompetitors);

                    break;
                default:
                    Console.WriteLine("SELECT A VALID OPTION AND TRY AGAIN");
                    break;
            }
        }

        #region MDC

        public static int mdc(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        public static int mdcList(int[] numberList)
        {
            int mdcResult = numberList[0];

            for (int i = 1; i < numberList.Length; i++)
            {
                mdcResult = mdc(mdcResult, numberList[i]);
            }
            return mdcResult;
        }

        #endregion

        #region Calcule States
        public static int[] calculeStates(int[] states, int days)
        {
            int[] cell = new int[8];

            for (int i = 0; i < states.Length; i++)
            {
                if (i == states.Length - 1 || i == 0)
                    cell[i] = 0;

                else
                {
                    bool isValidPosLeft = i - days >= 0 ? true : false;
                    bool isValidposRight = i + days <= states.Length - 1 ? true : false;

                    if (isValidPosLeft && !isValidposRight)
                    {
                        if (states[i - days] == 0)
                            cell[i] = 0;
                        else
                            cell[i] = 1;
                    }

                    if (!isValidPosLeft && isValidposRight)
                    {
                        if (0 == states[i + days])
                            cell[i] = 0;
                        else
                            cell[i] = 1;
                    }

                    if (isValidPosLeft && isValidposRight)
                    {
                        if (states[i - days] == states[i + days])
                            cell[i] = 0;
                        else
                            cell[i] = 1;
                    }
                }
            }

            return (cell);
        }

        #endregion

        #region Top Competitors

        public static List<string> TopNCompetitors(int numCompetitors,
                                    int topNCompetitors,
                                    List<string> competitors,
                                    int numReviews, List<string> reviews)
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

    #endregion
}
