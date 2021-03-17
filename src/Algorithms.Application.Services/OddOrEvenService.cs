﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Application.Services
{
    public class OddOrEvenService : IOddOrEvenService
    {
        public bool OddOrEven(int param)
        {
            //Write a C# API that receives an integer N and returns a Boolean Z; 
            //the API shall determine if the given integer N is odd or even.
            //Considerations:
            //a)	it is ONLY allowed to use addition or subtraction operations;
            //b)	zero shall be considered as even;
            //c)	N is an integer which can be negative or positive;

            if (param == 0)
                return true;

            else if (param > 0)
            {
                while (param > 0)
                    param = param - 2;

                if (param == 0)
                    return true;

                else
                    return false;
            }

            else
            {
                while (param < 0)
                    param = param + 2;

                if (param == 0)
                    return true;
                else
                    return false;
            }
        }

        public int CheckOddNumberTimes(List<int> param)
        {
            //Write a C# API that receives an array of integers A and returns an integer X; 
            //the API shall return the integer that occurs an odd number of times.
            //Considerations:
            //a)	each integer in the array occurs an even number of times, except for one;
            //b) for example, given the array A = [6, 1, 5, 6, 9, 9, 5], the API should return 1;

            int x = 0;

            var obj = param.GroupBy(p => p).Where(p => p.Count() == 1).Select(p => p.Key).ToList();
            foreach (var aux in obj)
            {
                x = 1;
            }

            return x;
        }
    }
}
