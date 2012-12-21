using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using NUnit.Framework;
using OdeToFood.Controllers;

namespace OdeToFood.Tests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void PutsMessageInViewBag()
        {
            var controller = new HomeController();
            var result = controller.Index();
            Assert.IsNotNullOrEmpty(((ViewResult) result).ViewBag.Message);
        }
    }
}
