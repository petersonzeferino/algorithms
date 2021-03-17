using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Application
{
    public interface IFibonacciService
    {
        public int CheckFibonacciRecursive(int n);

        public int CheckFibonacci(int n);
    }
}
