using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
      Assert.AreEqual(result, FindFirstIndex(testString))
    }
  }
}
