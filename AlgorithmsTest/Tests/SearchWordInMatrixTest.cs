using Algorithms.Application;
using Algorithms.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsTest.Tests
{
    public class SearchWordInMatrixTest
    {
        [Fact(DisplayName = "Search Word In Matrix")]
        public void SearchWordInMatrixTestSuccess()
        {
            ISearchWordInMatrixService _searchWordInMatrixService = new SearchWordInMatrixService();

            string[,] M = new string[4, 4] { { "S", "L", "O", "C" }, { "R", "E", "S", "C" }, { "K", "D", "P", "W" }, { "N", "A", "I", "T" } };
            string S = "RDI";
            bool output = true;

            Assert.Equal(_searchWordInMatrixService.CheckSearchWordInMatrix(M, S), output);
        }
    }
}
