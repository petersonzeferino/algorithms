using System.Collections.Generic;

namespace Algorithms.Application
{
    public interface IMiniMaxSumService
    {
        List<long> GetMiniMaxSum(List<int> arr);
    }
}