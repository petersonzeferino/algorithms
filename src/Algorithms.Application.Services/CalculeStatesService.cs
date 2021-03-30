namespace Algorithms.Application.Services
{
    public class CalculeStatesService : ICalculeStatesService
    {
        public int[] CalculeStates(int[] states, int days)
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
