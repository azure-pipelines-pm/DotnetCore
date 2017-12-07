using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Web.Controllers;

namespace Web.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HomeController controller = new HomeController();
            ViewResult result = (ViewResult)controller.About();
            string message = result.ViewData["Message"].ToString();
            Assert.IsNotNull(message);
        }
    }
}
