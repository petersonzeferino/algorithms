using System.Collections.Generic;

namespace Algorithms.Application
{
    public interface IOddOrEvenService
    {
        public bool OddOrEven(int param);

        public int CheckOddNumberTimes(List<int> param);
    }
}
