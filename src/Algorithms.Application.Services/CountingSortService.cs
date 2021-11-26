using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Application.Services
{
    public class CountingSortService : ICountingSortService
    {
        public List<int> GetCountingSort(List<int> arr, int numberAlgorithm)
        {
            return numberAlgorithm switch
            {
                1 => SolutiontOne(arr),
                2 => SolutiontTwo(arr),
                _ => SolutiontOne(arr)
            };
        }

        private List<int> SolutiontOne(List<int> arr)
        {
            List<int> result = new List<int>();

            //int max = arr.Max();
            //for (int i = 0; i < max; i++)
            //    result.Add(0);

            for (int i = 0; i < 100; i++)
                result.Add(0);

            foreach (var item in arr)
            {
                var index = item - 1;

                if (index < 0)
                    result[0] += 1;
                else
                    result[item] += 1;
            }

            return result;
        }

        private List<int> SolutiontTwo(List<int> arr)
        {
            int[] result = new int[100];
            for (int i = 0; i < arr.Count(); i++)
                result[arr[i]]++;

            return result.ToList();
        }
    }
}