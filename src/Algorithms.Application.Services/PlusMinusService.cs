using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Application.Services
{
    public class PlusMinusService : IPlusMinusService
    {
        public string[] GetPlusMinus(List<int> arr)
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

            result.SetValue(resultPositive,0);
            result.SetValue(resultNegative,1);
            result.SetValue(resultZero,2);

            return result;
        }
    }
}