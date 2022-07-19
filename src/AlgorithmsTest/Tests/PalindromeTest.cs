using System.Linq;
using System.Text.RegularExpressions;
using Xunit;

namespace AlgorithmsTest.Tests
{
    public class PalindromeTest
    {
        //Write a C# API that receives a string S and returns a Boolean Z; the API shall 
        //determine if the content of the given string S is a palindrome.
        //Considerations:
        //a)	only alphanumeric characters should be considered when validating the string S;
        //b)	cases should be ignored;
        //c)	“Red rum, sir, is murder”, “A nut for a jar of tuna”, “A Santa at Nasa” and “A car, a man, a maraca” are examples of palindromes;

        [Theory(DisplayName = "Check value is palindrome")]
        [InlineData("Red rum, sir, is murder", true)]
        [InlineData("A nut for a jar of tuna", true)]
        [InlineData("A Santa at Nasa", true)]
        [InlineData("A car, a man, a maraca", true)]
        public void CheckPalindromeWithSuccess(string input, bool output)
        {
            Assert.Equal(CheckPalindrome(input.ToLower().Replace(" ", "").Replace(",", "")), output);
        }


        public bool CheckPalindrome(string param)
        {
            var reverseChar = param.ToCharArray().Reverse();
            string reverse = new string(reverseChar.ToArray()).ToLower().Replace(" ","").Replace(",", "");

            return param.Equals(reverse);
        }
    }
}