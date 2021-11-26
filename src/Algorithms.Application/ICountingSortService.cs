using System.Collections.Generic;

namespace Algorithms.Application
{
    public interface ICountingSortService
    {
        List<int> GetCountingSort(List<int> arr, int numberAlgorithm);
    }
}