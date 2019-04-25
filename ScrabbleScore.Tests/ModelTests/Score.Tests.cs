using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;
using System;

namespace ScrabbleScore.Tests
{
    [TestClass]
     public class WordTest
     {
        [TestMethod]
        public void WordConstructor_AcceptsStringFromInput_String()
        {
            // Arrange
            string variable = "sabrina";
            Word newUserInput = new Word (variable);

            // Act
            string getUserInput = newUserInput.GetWord();

            // Assert
            Assert.AreEqual (variable, getUserInput);
        }

        [TestMethod]
        public void GetValue_ChangeTheScore_Int()
        {
         // Arrange
            Score newUserScore = new Score (0);

            // Act
            int getUserScore = newUserScore.GetScore();

            // Assert
            Assert.AreEqual (2, (getUserScore + 2));
            
        }

        [TestMethod]
        public void CheckLetter_GetTrueWhenLeeterInArray_True()
        {
          // Arrange
            
            Check newCheck = new Check ();
            char letterA = 'a';
            // Act
            // Assert
            Assert.AreEqual (true, newCheck.CheckLetter(letterA));
            
        }
    }
}
