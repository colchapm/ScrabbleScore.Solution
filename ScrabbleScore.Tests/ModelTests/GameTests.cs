using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;
using System.Collections.Generic;
using System;

namespace ScrabbleScore.TestTools
{
  [TestClass]
  public class GameTest
  {
    [TestMethod]
    public void CheckScrabbleScore_CheckLetterA_One()
    {
      //Arrange
      string userEnteredText = "a";
      int score = 1;
      CheckScrabbleScore testObject = new CheckScrabbleScore();

      //Act
      int result = testObject.CheckScore(userEnteredText);

      //Assert
      Assert.AreEqual(score, result);
    }

    [TestMethod]
    public void CheckScrabbleScore_SplitWord_array()
    {
      //Arrange
      string userEnteredText = "scrabble";
      string[] splitTest = {"s", "c", "r", "a", "b", "b", "l", "e"};
      CheckScrabbleScore testObject = new CheckScrabbleScore();

      //Act
      int result = testObject.CheckScore(userEnteredText);

      //Assert
      Assert.AreEqual(splitTest, result);
    }
  }

}