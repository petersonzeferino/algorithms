using System;
using System.Collections.Generic;
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
    }
}
