﻿using Xunit;

namespace AlgorithmsTest.Tests
{
    public class MDCTest
    {
        [Fact(DisplayName = "Check number of pairs")]
        public void CheckNumberOfPairsTestSuccess()
        {
            int[] input = new int[] { 2, 4, 6, 8, 10 };
            int output = 2;

            Assert.Equal(ListMDC(input), output);
        }

        [Fact(DisplayName = "Check number of pairs - second test case")]
        public void CheckNumberOfPairsSecondTestSuccess()
        {
            int[] input = new int[] { 2, 3, 4, 5, 6 };
            int output = 1;

            Assert.Equal(ListMDC(input), output);
        }

        private int ListMDC(int[] numberList)
        {
            int mdcResult = numberList[0];

            for (int i = 1; i < numberList.Length; i++)
            {
                mdcResult = CaculeMDC(mdcResult, numberList[i]);
            }
            return mdcResult;
        }

        private int CaculeMDC(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}