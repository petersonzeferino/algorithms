using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Application.Services
{
    public class SearchWordInMatrixService : ISearchWordInMatrixService
    {
        public bool CheckSearchWordInMatrix(string[,] M, string S)
        {
            //Write a C# API that receives a matrix of characters M, a string S and returns a Boolean Z; 
            //the API shall return if the string S exists in the matrix M;
            //Considerations:
            //a)	the search in the matrix can move downwards, to the left and diagonally;
            //b)	for example, given the matrix M = [S, L, O, C][R, E, S, C][K, D, P, W][N, A, I, T] and the string S = “RDI”, the API should return ‘true’;

            int isValidate = 0;
            int textLenght = S.Length;

            String[] values = new String[textLenght];

            for (int i = 0; i < S.Length; i++)
                values[i] = S.Substring(i, 1);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var p = 0;
                    while (values.Length > p)
                    {
                        if (M[i, j] == values[p])
                            isValidate++;

                        p++;
                    }

                }
            }

            if (isValidate >= values.Length)
                return true;
            else
                return false;

        }

    }
}
