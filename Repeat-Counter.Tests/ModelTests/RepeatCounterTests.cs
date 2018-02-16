using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using RepeatCounterProject.Models;

namespace RepeatCounterProject.TestTools
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void FindFirstIndex_ReturnsIndexOfEqualChar_True()
    {
      RepeatCounter.SetUserSentence("want");
      RepeatCounter.SetUserWord("t");
      int result = 3;
      Assert.AreEqual(result, RepeatCounter.FindFirstIndex());
    }

    [TestMethod]
    public void GetIndexes_ReturnsAllIndexValuesWithEqualChar_True()
    {
      RepeatCounter.SetUserSentence("I want coffee today.");
      RepeatCounter.SetUserWord("tree");
      List<int> result = new List<int>(){5, 14};
      CollectionAssert.AreEqual(result, RepeatCounter.GetIndexes());
    }

    [TestMethod]
    public void SubstringIsEqual_ReturnsBool_True()
    {
      RepeatCounter.SetUserWord("apple");
      RepeatCounter.SetUserSentence("the apple");
      int startingIndex = 4;
      Assert.AreEqual(true, RepeatCounter.SubstringIsEqual(startingIndex));
    }

    [TestMethod]
    public void GetRepeatCount_ReturnNumberOfRepeats_True()
    {
      RepeatCounter.SetUserWord("cat");
      RepeatCounter.SetUserSentence("The cat is larger than a caterpillar.");
      Assert.AreEqual(1, RepeatCounter.GetRepeatCount());

      RepeatCounter.SetUserWord("a");
      RepeatCounter.SetUserSentence("");
      Assert.AreEqual(0, RepeatCounter.GetRepeatCount());

      RepeatCounter.SetUserWord("an");
      RepeatCounter.SetUserSentence("anna and annette the ant android are an awesome pair");
      Assert.AreEqual(1, RepeatCounter.GetRepeatCount());
    }
  }
}
