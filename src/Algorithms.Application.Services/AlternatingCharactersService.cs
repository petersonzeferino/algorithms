using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Application.Services
{
    public class AlternatingCharactersService : IAlternatingCharactersService
    {
        public int CheckAlgorithmsCharacter(string s)
        {
            int numberDeletion = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                    numberDeletion++;
            }

            return numberDeletion;
        }
    }
}
