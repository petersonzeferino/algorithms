﻿using Algorithms.Application;
using Algorithms.Application.Services;
using System.Collections.Generic;
using Xunit;

namespace AlgorithmsTest.Tests
{
    public class NumberOfPairsTest
    {
        [Fact(DisplayName = "Check number of pairs")]
        public void CheckNumberOfPairsServiceTestSuccess()
        {
            INumberOfPairsService _numberOfPairsService = new NumberOfPairsService();
            
            int[] input = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int output = 3;

            Assert.Equal(NumberOfPairs(input), output);
        }

        public int NumberOfPairs(int[] sockets)
        {
            if (sockets.Length <= 0)
                return 0;

            List<int> ListSockets = new List<int>(sockets);
            int count = 0;

            while (ListSockets.Count >= 1)
            {
                int index = ListSockets.LastIndexOf(ListSockets[0]);

                if (index > 0)
                {
                    ListSockets.RemoveAt(index);
                    count++;
                }

                ListSockets.RemoveAt(0);

            }

            return count;
        }
    }
}
