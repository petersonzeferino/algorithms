using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsTest.Bases
{
    public class BaseTest<TService> : IDisposable
    {
        public BaseTest()
        {
            // Do "global" initialization here; Only called once.
        }

        public void Dispose()
        {
            // Do "global" teardown here; Only called once.
        }
    }
}
