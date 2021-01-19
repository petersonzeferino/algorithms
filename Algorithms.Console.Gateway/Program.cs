using Algorithms.Application;
using Algorithms.Application.Services.Algorithms;
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
                                "3 - Top Competitors " +
                                "\r\n" +
                                "4 - Create and read in file " +
                                "\r\n" +
                                "5 - Sock Merchant " +
                                "\r\n" +
                                 "6 - Array Left Rotation "
                             );

            var option = Console.ReadLine();
            IAlgorithmsService _algorithmsService = new AlgorithmsService();

            switch (option)
            {
                case "1":
                    int resultMdcList = _algorithmsService.MDC(TestCaseMDC());

                    Console.WriteLine("Result of MDC: " + resultMdcList.ToString());
                    break;
                case "2":
                    int[] resultCalculeStates;
                    string textResultCalculeStates = String.Empty;

                    TestCaseCalculeStatesEntity _testCaseCalculeStatesEntity = TestCaseCalculeStates();

                    resultCalculeStates = _algorithmsService.CalculeStates(_testCaseCalculeStatesEntity.States, _testCaseCalculeStatesEntity.Days);

                    foreach (var item in resultCalculeStates)
                    {
                        textResultCalculeStates += item + " ";
                    }

                    Console.WriteLine("Result of States: " + textResultCalculeStates);
                    break;
                case "3":
                    TestCaseTopCompetitorsEntity _testCaseTopCompetitorsEntity = TestCaseTopCompetitors();

                    var resultTopNCompetitors = _algorithmsService.TopCompetitors(_testCaseTopCompetitorsEntity.NumberCompetitors, _testCaseTopCompetitorsEntity.TopNumberCompetitors, _testCaseTopCompetitorsEntity.Competitors, _testCaseTopCompetitorsEntity.NumberReviews, _testCaseTopCompetitorsEntity.Reviews);

                    string textTopNCompetitors = String.Empty;

                    foreach (var item in resultTopNCompetitors)
                    {
                        textTopNCompetitors += item + " ";
                    }

                    Console.WriteLine("Result of Top Competitors: " + textTopNCompetitors);

                    break;
                case "4":
                    _algorithmsService.CreateAndReadInFile();
                    break;
                case "5":
                    int value = _algorithmsService.NumberOfPairs(TestCaseNumberOfPairs());

                    Console.WriteLine($"Number of pairs is {value}");
                    break;
                case "6":
                    _algorithmsService.ArrayLeftRotation();

                    Console.WriteLine($"Array result is {1}");
                    break;

                default:
                    Console.WriteLine("SELECT A VALID OPTION AND TRY AGAIN");
                    break;
            }
        }

        #region Test Case

        public static int[] TestCaseMDC()
        {
            //int[] numberList = new int[] { 2, 3, 4, 5, 6 };
            int[] numberList = new int[] { 2, 4, 6, 8, 10 };

            return numberList;
        }

        public static TestCaseCalculeStatesEntity TestCaseCalculeStates()
        {

            //int[] states = new int[] { 1, 1, 1, 0, 1, 1, 1, 1 };
            //int days = 2;

            int[] states = new int[] { 1, 0, 0, 0, 0, 1, 0, 0 };
            int days = 1;

            TestCaseCalculeStatesEntity entity = new TestCaseCalculeStatesEntity();
            entity.States = states;
            entity.Days = days;

            return entity;
        }

        public static TestCaseTopCompetitorsEntity TestCaseTopCompetitors()
        {
            TestCaseTopCompetitorsEntity entity = new TestCaseTopCompetitorsEntity();
            entity.NumberCompetitors = 5;
            entity.TopNumberCompetitors = 2;
            entity.NumberReviews = 3;
            entity.Competitors = new List<string> {
                                                    "anacell", "betacellular", "cetracular", "deltacellular", "eurocell"
                                                  };

            entity.Reviews = new List<string> {
                                                "Best services provided by anacell",
                                                "betacellular has great services",
                                                "anacell provides much better services than all other"
                                              };

            //entity.NumberCompetitors = 5;
            //entity.TopNumberCompetitors = 2;
            //entity.NumberReviews = 5;
            //entity.Competitors = new List<string> {
            //                                        "anacell", "betacellular", "cetracular", "deltacellular", "eurocell"
            //                                      };

            //entity.Reviews = new List<string> {
            //                                    "I love anacell Best services provided by anacell in the town",
            //                                    "betacellular has great services",
            //                                    "deltacellular provides much better services than betacellular",
            //                                    "cetracular is worse than eurocell",
            //                                    "betacellular is better than deltacellular"
            //                                   };

            return entity;
        }

        public static int[] TestCaseNumberOfPairs() 
        {
            return new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
        }

    #endregion

    #region

    public class TestCaseCalculeStatesEntity
        {
            public int[] States { get; set; }
            public int Days { get; set; }
        }

        public class TestCaseTopCompetitorsEntity
        {
            public int NumberCompetitors { get; set; }
            public int TopNumberCompetitors { get; set; }
            public List<string> Competitors { get; set; }
            public int NumberReviews { get; set; }
            public List<string> Reviews { get; set; }
        }

        #endregion

    }
}