using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc; 
using RepeatCounterProject.Models;
using RepeatCounterProject.Controllers;

namespace RepeatCounterProject.ControllerTests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnsView_True()
    {
      HomeController controller = new HomeController();
      IActionResult actionResult = controller.Index();
      ViewResult result = actionResult as ViewResult;

      Assert.IsInstanceOfType(actionResult, typeof(ViewResult));
    }
  }
}
