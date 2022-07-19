using Algorithms.Application;
using Algorithms.Application.Services;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AlgorithmsTest.Tests
{
    public class CalculeStatesTest
    {
        [Theory(DisplayName = "Calcule States")]
        [MemberData(nameof(GetParameters), parameters: 2)]

        public void CalculeStatesTestSuccess(int[] states, int days)
        {
            ICalculeStatesService _calculeStatesService = new CalculeStatesService();

            //int[] states = new int[] { 1, 1, 1, 0, 1, 1, 1, 1 };
            //int days = 2;

            //int[] states = new int[] { 1, 0, 0, 0, 0, 1, 0, 0 };
            //int days = 1;

            int[] output = new int[] { 0, 1, 0, 0, 1, 0, 1, 0 };

            Assert.Equal(CalculeStates(states, days), output);
        }

        public static IEnumerable<object[]> GetParameters(int numberTest)
        {
            var allParams = new List<object[]>
            {
                new object[] {
                    new int[] { 1, 1, 1, 0, 1, 1, 1, 1 },
                    2
                },
                new object[] {
                    new int[] { 1, 0, 0, 0, 0, 1, 0, 0 },
                    1
                },
            };

            return allParams.Take(numberTest);
        }

        private int[] CalculeStates(int[] states, int days)
        {
            int[] cell = new int[8];

            for (int i = 0; i < states.Length; i++)
            {
                if (i == states.Length - 1 || i == 0)
                    cell[i] = 0;

                else
                {
                    bool isValidPosLeft = i - days >= 0 ? true : false;
                    bool isValidposRight = i + days <= states.Length - 1 ? true : false;

                    if (isValidPosLeft && !isValidposRight)
                    {
                        if (states[i - days] == 0)
                            cell[i] = 0;
                        else
                            cell[i] = 1;
                    }

                    if (!isValidPosLeft && isValidposRight)
                    {
                        if (0 == states[i + days])
                            cell[i] = 0;
                        else
                            cell[i] = 1;
                    }

                    if (isValidPosLeft && isValidposRight)
                    {
                        if (states[i - days] == states[i + days])
                            cell[i] = 0;
                        else
                            cell[i] = 1;
                    }
                }
            }

            return (cell);
        }
    }
}