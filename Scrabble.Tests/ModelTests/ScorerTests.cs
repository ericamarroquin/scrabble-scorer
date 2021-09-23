using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Models.Tests
{
  [TestClass]
  public class ScorerTests
  {
    [TestMethod]
    public void ScrabbleScore_GetOneLetterScore_1()
    {
      Assert.AreEqual(1, Scorer.ScrabbleScore("a"));
    }
    [TestMethod]
    public void ScrabbleScore_GetThreeLetterScore_5()
    {
      Assert.AreEqual(5, Scorer.ScrabbleScore("Cat"));
    }
    [TestMethod]
    public void ScrabbleScore_GetLargeWordScore_22()
    {
      Assert.AreEqual(22, Scorer.ScrabbleScore("expectation"));
    }

    
  }

}