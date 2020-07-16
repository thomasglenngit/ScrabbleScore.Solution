using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName.Models;

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
  }
}