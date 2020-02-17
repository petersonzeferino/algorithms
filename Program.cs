using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultMdcList;
            int[] resultCalculeStates;
            string textResultCalculeStates = String.Empty;

            //int[] numberList = new int[] { 2, 3, 4, 5, 6 };
            int[] numberList = new int[] { 2, 4, 6, 8, 10 };

            resultMdcList = mdcList(numberList);

            //int[] states = new int[] { 1, 1, 1, 0, 1, 1, 1, 1 };
            //int days = 2;

            int[] states = new int[] { 1, 0, 0, 0, 0, 1, 0, 0 };
            int days = 1;

            resultCalculeStates = calculeStates(states, days);

            for (int i = 0; i < resultCalculeStates.Length; i++)
            {
                textResultCalculeStates += resultCalculeStates[i].ToString() + " ";
            }

            Console.WriteLine(
                                "Result of MDC: " + resultMdcList.ToString() +
                                "\r\n" +
                                "Result of States: " + textResultCalculeStates
                             );
        }

        public static int mdc(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        //Calcule MDC the list of numbers
        public static int mdcList(int[] numberList)
        {
            int mdcResult = numberList[0];

            for (int i = 1; i < numberList.Length; i++)
            {
                mdcResult = mdc(mdcResult, numberList[i]);
            }
            return mdcResult;
        }

        public static int[] calculeStates(int[] states, int days)
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
