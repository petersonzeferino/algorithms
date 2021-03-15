using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Application.Services
{
    public class MDCService : IMDCService
    {
        public int ListMDC(int[] numberList)
        {
            int mdcResult = numberList[0];

            for (int i = 1; i < numberList.Length; i++)
            {
                mdcResult = CaculeMDC(mdcResult, numberList[i]);
            }
            return mdcResult;
        }

        public int CaculeMDC(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}
