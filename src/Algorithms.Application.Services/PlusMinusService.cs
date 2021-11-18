using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Application.Services
{
    public class PlusMinusService : IPlusMinusService
    {
        public List<string> GetPlusMinus(List<int> arr)
        {
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

            result.Add(resultPositive);
            result.Add(resultNegative);
            result.Add(resultZero);

            return result;
        }
    }
}