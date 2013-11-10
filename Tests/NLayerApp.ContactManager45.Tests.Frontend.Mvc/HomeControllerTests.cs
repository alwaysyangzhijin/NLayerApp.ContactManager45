using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLayerApp.ContactManager45.Web.Mvc.Controllers;
using System.Web.Mvc;

namespace NLayerApp.ContactManager45.Tests.Frontend.Mvc
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void IndexHasNoModel()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual(null, result.Model);
        }
    }
}
