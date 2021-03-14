using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Application
{
    public interface ISearchWordInMatrixService
    {
        public bool SearchWordInMatrix(String[,] M, String S);
    }
}
