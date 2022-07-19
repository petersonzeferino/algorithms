using System;
using System.Collections.Generic;
using Xunit;

namespace AlgorithmsTest.Tests
{

    public class PlusMinusTest
    {
        [Theory(DisplayName = "PlusMinus")]
        [InlineData("4,3,-9,0,4,1", "0.500000,0.333333,0.166667")]
        [InlineData("1,2,3,-1,-2,-3,0,0", "0.375000,0.375000,0.250000")]
        public void PlusMinusTestWithSuccess(string param, string result)
        {
            List<int> arr = new List<int>();
            foreach (var item in param.Split(","))
                arr.Add(Convert.ToInt32(item));

            var response = GetPlusMinus(arr);

            Console.WriteLine($"{response[0]}{Environment.NewLine}" +
                  $"{response[1]}{Environment.NewLine}" +
                  $"{response[2]}");

            var isEqual = false;
            var arrResult = result.Split(",");
            for (int i = 0; i < response.Length; i++)
            {
                if (response[i] == arrResult[i])
                    isEqual = true;
            }

            Assert.True(isEqual);            
        }

        private string[] GetPlusMinus(List<int> arr)
        {
            decimal total = arr.Count;
            decimal zero = 0;
            decimal negative = 0;
            decimal positive = 0;
            string[] result = new string[3];

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

            result.SetValue(resultPositive, 0);
            result.SetValue(resultNegative, 1);
            result.SetValue(resultZero, 2);

            return result;
        }
    }
}