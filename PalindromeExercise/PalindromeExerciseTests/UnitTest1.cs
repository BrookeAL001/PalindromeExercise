using System;
using Xunit;
using PalindromeExercise;

namespace Palindrome.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("elephant", false)]
        [InlineData("kayak", true)]
        [InlineData("rotator", true)]
        [InlineData("tree", false)]
        
        public void Test1(string word, bool expected)
        {
            //arrange
            var tester = new WordSmith();
            //act
            var actual = tester.IsAPalindrome(word);
            //assert
            Assert.Equal(actual, expected);
        }
    }
}
