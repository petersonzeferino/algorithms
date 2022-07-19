using Xunit;

namespace AlgorithmsTest.Tests
{
    public class FibonacciTest
    {
        [Theory(DisplayName = "Check fibonacci recursive")]
        [InlineData(3,2)]
        [InlineData(6, 8)]
        public void CheckFibonacciRecursiveWithSuccess(int input, int output)
        {
            Assert.Equal(CheckFibonacciRecursive(input), output);
        }

        private int CheckFibonacciRecursive(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return CheckFibonacciRecursive(n - 1) + CheckFibonacciRecursive(n - 2);
        }

        private int CheckFibonacci(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;

            if (n == 0) return 0;
            if (n == 1) return 1;


            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }

            return result;
        }
    }
}