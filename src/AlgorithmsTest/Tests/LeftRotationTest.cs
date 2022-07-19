using Algorithms.Application;
using Algorithms.Application.Services;
using System;
using Xunit;

namespace AlgorithmsTest.Tests
{
    public class LeftRotationTest
    {
        [Fact(DisplayName = "Check number of left rotations")]
        public void CheckNumberOfLestRotationTestSuccess()
        {
            ILeftRotationService _leftRotationService = new LeftRotationService();

            int[] input = new int[] { 1, 2, 3, 4, 5 };
            int numberOfRotation = 4;
            int[] output = new int[] { 5, 1, 2, 3, 4 };

            Assert.Equal(ArrayLeftRotation(input, numberOfRotation), output);
        }

        private int[] ArrayLeftRotation(int[] a, int d)
        {
            int[] rotLeftArray = new int[a.Length];
            int size = a.Length;

            for (int p = 0; p < a.Length; p++)
            {
                int calcPosition = p - d;
                int position = 0;

                if (calcPosition > 0)
                    position = calcPosition;
                else if (calcPosition < 0)
                    position = Math.Abs((-size - calcPosition));

                rotLeftArray[position] = a[p];
            }

            return rotLeftArray;

        }



    }
}
