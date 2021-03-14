using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Application
{
    public interface IOddOrEvenService
    {
        public bool OddOrEven(int param);

        public int CheckOddNumberTimes(List<int> param);
    }
}
