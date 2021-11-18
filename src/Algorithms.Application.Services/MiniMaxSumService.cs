using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Application.Services
{
    public class MiniMaxSumService : IMiniMaxSumService
    {
        public List<long> GetMiniMaxSum(List<int> arr)
        {
            List<int> arrCopy = arr.ToList();
            List<long> compare = new List<long>();

            for (int i = 0; i < arr.Count; i++)
            {
                arr.RemoveAt(i);
                long sum = 0;

                foreach (var item in arr)
                    sum += item;

                compare.Add(sum);

                arr = arrCopy.ToList();
            }

            return compare;
        }
    }
}