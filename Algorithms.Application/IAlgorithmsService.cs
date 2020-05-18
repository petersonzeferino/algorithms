using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Application
{
    public interface IAlgorithmsService
    {
        public bool OddOrEven(int param);

        public bool CheckPalindrome(string param);

        public int CheckOddNumberTimes(List<int> param);

        public bool SearchWordInMatrix(String[,] M, String S);

        public List<string> TopCompetitors(int numCompetitors,
                                           int topNCompetitors,
                                           List<string> competitors,
                                           int numReviews, List<string> reviews);

        public int[] CalculeStates(int[] states, int days);

        public int MDC(int[] numberList);
    }
}
