using System;
using System.Collections.Generic;

namespace Algorithms.Application.Services
{
    public class DiagonalDifferenceService : IDiagonalDifferenceService
    {
        public int CalculeDiagonalDifference(List<List<int>> arr)
        {
            //arr = new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 9, 8, 9 } };
            //arr = new List<List<int>> { new List<int> { 11, 2, 4 }, new List<int> { 4, 5, 6 }, new List<int> { 10, 8, -12 } };
            //arr = new List<List<int>> { new List<int> { -1, 1, -7, -8 }, new List<int> { -10, -8, -5, -2 }, new List<int> { 0, 9, 7, -1 }, new List<int> { 4, 4, -2, 1 } };

            int diagonal = 0;
            int inverseDiagonal = 0;
            int capacity = arr.Count - 1;

            while (capacity != -1)
            {
                int current = arr[capacity][capacity];
                diagonal += current;
                capacity--;
            }

            capacity = arr.Count - 1;
            int start = 0;

            while (capacity != -1)
            {
                int current = arr[start][capacity];
                inverseDiagonal += current;
                capacity--;
                start++;
            }

            int result;
            if (diagonal > inverseDiagonal)
                result = Math.Abs(diagonal - inverseDiagonal);
            else
                result = Math.Abs(inverseDiagonal - diagonal);

            return result;
        }
    }
}