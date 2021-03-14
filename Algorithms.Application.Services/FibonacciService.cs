using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Application.Services
{
    public class FibonacciService : IFibonacciService
    {
        public int CheckFibonacciRecursive(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return CheckFibonacciRecursive(n - 1) + CheckFibonacciRecursive(n - 2);
        }

        public int CheckFibonacci(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;

            if (n == 0) return 0; 
            if (n == 1) return 1; 


            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }

            return result;
        }
    }
}
