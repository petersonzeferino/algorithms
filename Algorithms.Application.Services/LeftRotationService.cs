using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Application.Services
{
    public class LeftRotationService : ILeftRotationService
    {
        public int[] ArrayLeftRotation()
        {

            int[] a = new int[] { 1, 2, 3, 4, 5 }; //Param - Array 
            int d = 4; //Param - Number of Rotation 

            int[] rotLeftArray = new int[a.Length];
            int size = a.Length;

            for (int p = 0; p < a.Length; p++)
            {
                int calcPosition = p - d;
                int position = 0;

                if (calcPosition > 0)
                    position = calcPosition;
                else if (calcPosition < 0)
                    position = Math.Abs((-size - calcPosition));

                rotLeftArray[position] = a[p];
            }

            return rotLeftArray;

        }
    }
}
