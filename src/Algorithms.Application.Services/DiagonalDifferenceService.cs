using System;
using System.Collections.Generic;

namespace Algorithms.Application.Services
{
    public class DiagonalDifferenceService : IDiagonalDifferenceService
    {
        public int CalculeDiagonalDifference(List<List<int>> arr)
        {
            int diagonal = 0;
            int inverseDiagonal = 0;
            int capacity = arr.Count - 1;

            while (capacity != -1)
            {
                var current = arr[capacity][capacity];
                diagonal += current;
                capacity--;
            }

            capacity = arr.Count - 1;
            int start = 0;

            while (capacity != -1)
            {
                var current = arr[start][capacity];
                inverseDiagonal += current;
                capacity--;
                start++;
            }

            int result;
            if (diagonal > inverseDiagonal)
                result = diagonal - inverseDiagonal;
            else
                result = inverseDiagonal - diagonal;

            return Math.Abs(result);
        }
    }
}