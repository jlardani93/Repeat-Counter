using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using RepeatCounterProject.Models;
using RepeatCounterProject.Controllers;

namespace RepeatCounterProject.ControllerTests
{
  [TestClass]
  public class RepeatCounterControllerTest
  {
    [TestMethod]
    public void Form_ReturnsView_true()
    {
      RepeatCounterController controller = new RepeatCounterController();
      IActionResult actionResult = controller.Form();
      ActionResult result = actionResult as ActionResult;

      Assert.IsInstanceOfType(result, typeof(ActionResult));
    }
  }
}
