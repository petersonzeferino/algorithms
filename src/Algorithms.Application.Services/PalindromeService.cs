using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Algorithms.Application.Services
{
    public class PalindromeService : IPalindromeService
    {
        public bool CheckPalindrome(string param)
        {
            //Write a C# API that receives a string S and returns a Boolean Z; the API shall 
            //determine if the content of the given string S is a palindrome.
            //Considerations:
            //a)	only alphanumeric characters should be considered when validating the string S;
            //b)	cases should be ignored;
            //c)	“Red rum, sir, is murder”, “A nut for a jar of tuna”, “A Santa at Nasa” and “A car, a man, a maraca” are examples of palindromes;

            string text = param.ToLower().Replace(" ", "").Replace(".", "").Replace(",", "").Replace(";", "");
            string expression = @"^[a-z0-9]";

            Regex r = new Regex(expression, RegexOptions.IgnoreCase);
            Match m = r.Match(param);

            if (m.Success)
            {
                if (text.Length == 1)
                    return true;

                //int i = 0;
                //int j = text.Length;

                //while (i != j)
                //{
                //    if (text.Substring(i, 1) != text.Substring(j - 1, 1))
                //        return Z = false;                       

                //    i++;
                //    j--;
                //}

                //return Z = true;
                else if (text.Substring(0, 1) == text.Substring(text.Length - 1, 1))
                    return true;

                else
                    return false;
            }
            else
                return false;
        }
    }
}
