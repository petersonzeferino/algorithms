using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Application.Services
{
    public class NumberOfPairsService : INumberOfPairsService
    {
        public int NumberOfPairs(int[] sockets)
        {
            if (sockets.Length <= 0)
                return 0;

            List<int> ListSockets = new List<int>(sockets);
            int count = 0;

            while (ListSockets.Count >= 1)
            {
                int index = ListSockets.LastIndexOf(ListSockets[0]);

                if (index > 0)
                {
                    ListSockets.RemoveAt(index);
                    count++;
                }

                ListSockets.RemoveAt(0);

            }

            return count;
        }
    }
}
