using Algorithms.Application;
using Algorithms.Application.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace AlgorithmsTest.Tests
{

    public class PlusMinusTest
    {

        [Fact(DisplayName = "PlusMinus")]
        public void PlusMinusTestWithSuccess()
        {
            List<int> arr = new List<int>() { -4, 3, -9, 0, 4, 1 };
            decimal total = arr.Count;
            decimal zero = 0;
            decimal negative = 0;
            decimal positive = 0;
            List<string> result = new List<string>();

            foreach (int item in arr)
            {
                if (item == 0)
                    zero++;
                else if (item < 0)
                    negative++;
                else
                    positive++;
            }

            var resultPositive = Math.Round(positive / total, 6).ToString("F6").Replace(",", ".");
            var resultNegative = Math.Round(negative / total, 6).ToString("F6").Replace(",", ".");
            var resultZero = Math.Round(zero / total, 6).ToString("F6").Replace(",", ".");

            Console.WriteLine($"{resultPositive}{Environment.NewLine}" +
                              $"{resultNegative}{Environment.NewLine}" +
                              $"{resultZero}");

            result.Add(resultPositive);
            result.Add(resultNegative);
            result.Add(resultZero);
        }
    }
}