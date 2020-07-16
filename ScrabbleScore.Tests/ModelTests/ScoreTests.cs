using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName.Models;
using System.Collections.Generic;

namespace ProjectName.Tests
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void ScoreConstructor_CreatesInstanceOfItem_Score()
    {
      Score newScore = new Score();
      Assert.AreEqual(typeof(Score), newScore.GetType());
    } 
  
    [TestMethod]
    public void GetLetterScores_ReturnsLetterScores_Dictionary()
    {
      Dictionary<string, int> testLetterScores = new Dictionary<string, int>() {{"A", 1}, {"E", 1}, {"I", 1}, {"O", 1}, {"U", 1}, {"L", 1}, {"N", 1}, {"R", 1}, {"S", 1}, {"T", 1}, {"D", 2}, {"G", 2}, {"B", 3}, {"C", 3}, {"M", 3}, {"P", 3}, {"F", 4}, {"H", 4}, {"V", 4}, {"W", 4}, {"Y", 4}, {"K", 5}, {"J", 8}, {"X", 8}, {"Q", 10}, {"Z", 10} };
      Score newScore = new Score();
      Dictionary<string, int> result = newScore.LetterScores;
      CollectionAssert.AreEqual(testLetterScores, result);
    }

    [TestMethod]
    public void LetterValue_GetLetterScore_Int()
    {
      Score newScore = new Score();
      int result = newScore.LetterValue("A");
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void WordScore_GetWordScore_Int()
    {
      Score newScore = new Score();
      int result = newScore.WordScore("MUZJIKS");
      Assert.AreEqual(29, result);
    }
  }
}