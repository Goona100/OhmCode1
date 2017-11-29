using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ohm;
using Ohm.Controllers;

namespace Ohm.Tests.Controllers
{
    [TestClass]
    public class OhmControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            OhmController controller = new OhmController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetOhm_Index()
        {
            // Arrange
            OhmController controller = new OhmController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetOhm_Value()
        {
            // Arrange
            OhmController controller = new OhmController();

            // Act
            ViewResult result = controller.GetOhm("Brown", "Red", "Orange", "Black") as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("12000 OHMS", result.ViewData["Ohm"]);
        }




    }
}
