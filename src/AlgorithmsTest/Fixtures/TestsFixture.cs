using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsTest.Fixtures
{
    public class TestsFixture : IDisposable
    {
        public TestsFixture()
        {
            // Do "global" initialization here; Only called once.
        }

        public void Dispose()
        {
            // Do "global" teardown here; Only called once.
        }
    }
}
