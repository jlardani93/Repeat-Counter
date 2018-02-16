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
      string testString = "want";
      int result = 3;
      Assert.AreEqual(result, RepeatCounter.FindFirstIndex("t", testString));
    }

    [TestMethod]
    public void GetIndexes_ReturnsAllIndexValuesWithEqualChar_True()
    {
      string testString = "I want coffee today.";
      List<int> result = new List<int>(){5, 14};
      CollectionAssert.AreEqual(result, RepeatCounter.GetIndexes("tree", testString));
    }

    [TestMethod]
    public void SubstringIsEqual_ReturnsBool_True()
    {
      string userWord = "apple";
      int startingIndex = 4;
      string testString = "the apple";
      Assert.AreEqual(true, RepeatCounter.SubstringIsEqual(userWord, testString, startingIndex));
    }

    [TestMethod]
    public void GetRepeatCount_ReturnNumberOfRepeats_True()
    {
      string userWord = "cat";
      string testString = "The cat is larger than a caterpillar.";
      Assert.AreEqual(1, RepeatCounter.GetRepeatCount(userWord, testString));

      userWord = "an";
      testString = "    ";
      Assert.AreEqual(0, RepeatCounter.GetRepeatCount(userWord, testString));

      userWord = "an";
      testString = "anna and annette the ant android are an awesome pair";
      Assert.AreEqual(1, RepeatCounter.GetRepeatCount(userWord, testString));
    }
  }
}
