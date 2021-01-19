using System;
using Xunit;

namespace AlgorithmsTest
{
    public class OddOrEvenTest
    {
        [Theory(DisplayName = "Check value is Odd or Even")]
        [InlineData(0, true)]
        [InlineData(1, false)]
        [InlineData(5, false)]
        [InlineData(10, true)]
        public void OddOrEven(int param, bool retorno)
        {
           Assert.Equal(CheckOddorEven(param), retorno);
        }

        private bool CheckOddorEven(int param)
        {
            if (param == 0)
                return true;

            else if (param > 0)
            {
                while (param > 0)
                    param = param - 2;

                if (param == 0)
                    return true;

                else
                    return false;
            }

            else
            {
                while (param < 0)
                    param = param + 2;

                if (param == 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
