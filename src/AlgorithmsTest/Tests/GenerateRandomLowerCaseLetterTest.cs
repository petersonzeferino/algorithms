using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsTest.Tests
{
    /// <summary>
    /// Your program will generate random lowercase letters so that you can produce a full sequential alphabet.
    /// First generate random lowercase letters and collect them until you can produce the following output.
    /// Required Output: abcdefghijklmnopqrstuvwxyz
    /// (The English alphabet contains 26 letters)
    /// </summary>
    public class GenerateRandomLowerCaseLetterTest
    {        
        [Fact]
        public void GenerateRandomLowerCaseLetter_ShouldGetAlphatetWithSuccess()
        {
            //Arrange
            string expected = "abcdefghijklmnopqrstuvwxyz";

            //Act
            string result = GetAlphabet();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GenerateRandomLowerCaseLetter_ShouldGenerateRandomLowerCaseLetterWithSuccess()
        {
            //Arrange
            string expected = GenerateLetter(GetRandomLowercaseLetter());

            //Act
            string result = GenerateLetter(GetRandomLowercaseLetter());

            //Assert
            Assert.NotEqual(expected, result);
        }

        protected string GetAlphabet()
        {
            SortedSet<int> letters = new SortedSet<int>();

            while (letters.Count != 26)
            {
                var letter = GetRandomLowercaseLetter();
                letters.Add(letter);
            }

            return GenerateAlphabetLetters(letters);
        }

        protected int GetRandomLowercaseLetter()
        {
            Random rnd = new Random();
            int ascii_index = rnd.Next(97, 123);
            return ascii_index;
        }

        protected string GenerateAlphabetLetters(SortedSet<int> letters)
        {
            string alphabet = string.Empty;

            foreach (var item in letters)
                alphabet += GenerateLetter(item);

            return alphabet;
        }

        protected string GenerateLetter(int ascii_index) =>
            Convert.ToChar(ascii_index).ToString();
    }
}