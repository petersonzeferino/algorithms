using System.Collections.Generic;

namespace Algorithms.Application.Services
{
    public class LonelyIntegerService : ILonelyIntegerService
    {
        public int GetLonelyInteger(List<int> arr)
        {
            var response = 0;
            foreach (var item in arr)
            {
                if (arr.FindAll(x => x == item).Count == 1)
                {
                    response = item;
                    break;
                }
            }

            return response;
        }
    }
}