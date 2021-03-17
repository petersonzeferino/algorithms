using Algorithms.Application;
using Algorithms.Application.Services;
using Xunit;

namespace AlgorithmsTest.Tests
{
    public class CalculeStatesTest
    {
        [Fact(DisplayName = "Calcule States")]
        public void CalculeStatesTestSuccess()
        {
            ICalculeStatesService _calculeStatesService = new CalculeStatesService();

            //int[] states = new int[] { 1, 1, 1, 0, 1, 1, 1, 1 };
            //int days = 2;

            int[] states = new int[] { 1, 0, 0, 0, 0, 1, 0, 0 };
            int days = 1;

            int[] output = new int[] { 0, 1, 0, 0, 1, 0, 1, 0 };

            Assert.Equal(_calculeStatesService.CalculeStates(states, days), output);
        }
    }
}
